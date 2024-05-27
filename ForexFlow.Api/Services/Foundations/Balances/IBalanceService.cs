//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using ForexFlow.Api.Models.Foundations.Balances;

namespace ForexFlow.Api.Services.Foundations.Balances
{
	public interface IBalanceService
	{
		ValueTask<Balance> AddBalanceAsync(Balance Balance);
		IQueryable<Balance> SelectAllBalances();
		ValueTask<Balance> SelectBalanceByIdAsync(Guid Id);
		ValueTask<Balance> ModifyBalanceAsync(Balance Balance);
		ValueTask<Balance> RemoveBalanceAsync(Guid Id);
	}
}
