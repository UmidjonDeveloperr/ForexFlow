using ForexFlow.Api.Models.Foundations.Rates;

namespace ForexFlow.Api.Services.Processings.Rates
{
    public interface IRateProcessingService
    {
        ValueTask<Rate> GetRatesAsync();
    }
}
