using ForexFlow.Api.Brokers.Storages;
using ForexFlow.Api.Models.Foundations.Rates;

namespace ForexFlow.Api.Services.Foundations.Rates
{
	public partial class RateService
	{
		private readonly IStorageBroker storageBroker;

		public RateService(IStorageBroker storageBroker)
		{
			this.storageBroker = storageBroker;
		}

		public async ValueTask<Rate> AddRateAsync(Rate Rate) =>
			await this.storageBroker.InsertRateAsync(Rate);

		public IQueryable<Rate> SelectAllRates() =>
			this.storageBroker.RetrieveAllRates();

		public async ValueTask<Rate> SelectRateById(Guid Id) =>
			await this.storageBroker.RetrieveRateById(Id);

		public async ValueTask<Rate> ModifyRateAsync(Rate Rate) =>
			await this.storageBroker.UpdateRateAsync(Rate);

		public async ValueTask<Rate> RemoveRateAsync(Guid Id)
		{
			Rate gettingRate = await this.storageBroker.RetrieveRateById(Id);

			return await this.storageBroker.DeleteRateAsync(gettingRate);
		}
	}
}
