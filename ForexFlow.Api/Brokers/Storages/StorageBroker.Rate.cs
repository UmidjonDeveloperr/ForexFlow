using ForexFlow.Api.Models.Foundations.Rates;
using Microsoft.EntityFrameworkCore;

namespace ForexFlow.Api.Brokers.Storages
{
	public partial class StorageBroker
	{
		DbSet<Rate> Rates { get; set; }

		public async ValueTask<Rate> InsertRateAsync(Rate Rate) =>
			await InsertAsync(Rate);

		public IQueryable<Rate> RetrieveAllRates() =>
			SelectAll<Rate>();

		public async ValueTask<Rate> RetrieveRateById(Guid Id) =>
			await SelectAsync<Rate>(Id);

		public async ValueTask<Rate> UpdateRateAsync(Rate Rate) =>
			await UpdateAsync(Rate);

		public async ValueTask<Rate> DeleteRateAsync(Rate Rate) =>
			await DeleteAsync(Rate);
	}
}
