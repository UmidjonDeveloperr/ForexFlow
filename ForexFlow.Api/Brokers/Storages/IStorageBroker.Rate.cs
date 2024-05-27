using ForexFlow.Api.Models.Foundations.Rates;

namespace ForexFlow.Api.Brokers.Storages
{
	public partial interface IStorageBroker
	{
		ValueTask<Rate> InsertRateAsync(Rate Rate);
		IQueryable<Rate> RetrieveAllRates();
		ValueTask<Rate> RetrieveRateById(Guid Id);
		ValueTask<Rate> UpdateRateAsync(Rate Rate);
		ValueTask<Rate> DeleteRateAsync(Rate Rate);
	}
}
