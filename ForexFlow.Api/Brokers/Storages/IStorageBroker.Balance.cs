//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using ForexFlow.Api.Models.Foundations.Balances;

namespace ForexFlow.Api.Brokers.Storages
{
	public partial interface IStorageBroker
	{
		ValueTask<Balance> InsertBalanceAsync(Balance Balance);
		IQueryable<Balance> RetrieveAllBalances();
		ValueTask<Balance> RetrieveBalanceById(Guid Id);
		ValueTask<Balance> UpdateBalanceAsync(Balance Balance);
		ValueTask<Balance> DeleteBalanceAsync(Balance Balance);
	}
}
