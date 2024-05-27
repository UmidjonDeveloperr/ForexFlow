using System.Net;
using ForexFlow.Api.Models.Foundations.Rates;
using ForexFlow.Api.Services.Foundations.Rates;
using Newtonsoft.Json.Linq;

namespace ForexFlow.Api.Services.Processings.Rates
{
    public class RateProcessingService : IRateProcessingService
    {
        private readonly IRateService rateService;

        public RateProcessingService(IRateService rateService) =>
            this.rateService = rateService;

        public async ValueTask<Rate> GetRatesAsync()
        {
            var maybeRate = this.rateService.SelectAllRates().FirstOrDefault();

            if (maybeRate is null)
            {
                Rate rate = new Rate
                {
                    Id = Guid.NewGuid(),
                    RUB = 0,
                    USD = 0,
                    UZS = 0
                };

                maybeRate = await this.rateService.AddRateAsync(rate);
            }

            string apiKey = "4362d7427e92bf6088063ea3";
            string apiUrl = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/USD";

            using (WebClient webClient = new WebClient())
            {
                string json = webClient.DownloadString(apiUrl);

                JObject jsonData = JObject.Parse(json);

                var rates = new List<string>
                {
                    "USD", "RUB", "UZS"
                };

                foreach (var rateType in rates)
                {
                    decimal exchangeRate = (decimal)jsonData["conversion_rates"][rateType];
                    float result = (float)(100 * exchangeRate);

                    switch (rateType)
                    {
                        case "USD":
                            maybeRate.USD = result;
                            break;
                        case "RUB":
                            maybeRate.RUB = result;
                            break;
                        case "UZS":
                            maybeRate.UZS = result;
                            break;
                    }
                }
            }

            return await this.rateService.ModifyRateAsync(maybeRate);
        }
    }
}
