//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using ForexFlow.Api.Models.Foundations.Balances;
using Microsoft.EntityFrameworkCore;

namespace ForexFlow.Api.Brokers.Storages
{
	public partial class StorageBroker
	{
		DbSet<Balance> Balances { get; set; }

		public async ValueTask<Balance> InsertBalanceAsync(Balance Balance) =>
			await InsertAsync(Balance);

		public IQueryable<Balance> RetrieveAllBalances() =>
			SelectAll<Balance>();

		public async ValueTask<Balance> RetrieveBalanceById(Guid Id) =>
			await SelectAsync<Balance>(Id);

		public async ValueTask<Balance> UpdateBalanceAsync(Balance Balance) =>
			await UpdateAsync(Balance);

		public async ValueTask<Balance> DeleteBalanceAsync(Balance Balance) =>
			await DeleteAsync(Balance);
	}
}
