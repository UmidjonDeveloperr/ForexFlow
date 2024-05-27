using ForexFlow.Api.Models.Foundations.Rates;

namespace ForexFlow.Api.Services.Foundations.Rates
{
	public interface IRateService
	{
		ValueTask<Rate> AddRateAsync(Rate Rate);
		IQueryable<Rate> SelectAllRates();
		ValueTask<Rate> SelectRateById(Guid Id);
		ValueTask<Rate> ModifyRateAsync(Rate Rate);
		ValueTask<Rate> RemoveRateAsync(Guid Id);
	}
}
