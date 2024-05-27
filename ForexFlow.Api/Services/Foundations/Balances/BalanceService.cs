//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using ForexFlow.Api.Brokers.Storages;
using ForexFlow.Api.Models.Foundations.Balances;

namespace ForexFlow.Api.Services.Foundations.Balances
{
    public partial class BalanceService : IBalanceService
    {
        private readonly IStorageBroker storageBroker;

        public BalanceService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public async ValueTask<Balance> AddBalanceAsync(Balance Balance) =>
            await this.storageBroker.InsertBalanceAsync(Balance);

        public IQueryable<Balance> SelectAllBalances() =>
            this.storageBroker.RetrieveAllBalances();

        public async ValueTask<Balance> SelectBalanceByIdAsync(Guid Id) =>
            await this.storageBroker.RetrieveBalanceById(Id);

        public async ValueTask<Balance> ModifyBalanceAsync(Balance Balance) =>
            await this.storageBroker.UpdateBalanceAsync(Balance);

        public async ValueTask<Balance> RemoveBalanceAsync(Guid Id)
        {
            Balance gettingBalance = await this.storageBroker.RetrieveBalanceById(Id);

            return await this.storageBroker.DeleteBalanceAsync(gettingBalance);
        }
    }
}
