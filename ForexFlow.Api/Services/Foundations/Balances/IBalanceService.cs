using ForexFlow.Api.Models.Foundations.Balances;

namespace ForexFlow.Api.Services.Foundations.Balances
{
	public interface IBalanceService
	{
		ValueTask<Balance> AddBalanceAsync(Balance Balance);
		IQueryable<Balance> SelectAllBalances();
		ValueTask<Balance> SelectBalanceById(Guid Id);
		ValueTask<Balance> ModifyBalanceAsync(Balance Balance);
		ValueTask<Balance> RemoveBalanceAsync(Guid Id);
	}
}
