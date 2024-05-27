//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using ForexFlow.Api.Models.Foundations.Rates;

namespace ForexFlow.Api.Services.Foundations.Rates
{
	public interface IRateService
	{
		ValueTask<Rate> AddRateAsync(Rate Rate);
		IQueryable<Rate> SelectAllRates();
		ValueTask<Rate> SelectRateByIdAsync(Guid Id);
		ValueTask<Rate> ModifyRateAsync(Rate Rate);
		ValueTask<Rate> RemoveRateAsync(Guid Id);
	}
}
