//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

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
