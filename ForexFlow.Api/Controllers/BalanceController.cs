//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using ForexFlow.Api.Models.Foundations.Balances;
using ForexFlow.Api.Services.Foundations.Balances;
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace ForexFlow.Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BalanceController : RESTFulController
	{
		private readonly IBalanceService balanceService;

		public BalanceController(IBalanceService BalanceService)
		{
			this.balanceService = balanceService;
		}

		[HttpPost]
		public async ValueTask<ActionResult<Balance>> PostBalanceAsync(Balance Balance)
		{
			Balance postedBalance = await this.balanceService.AddBalanceAsync(Balance);

			return Created(postedBalance);
		}

		[HttpGet]
		public ActionResult<Balance> GetAllBalances()
		{
			IQueryable<Balance> Balances = this.balanceService.SelectAllBalances();

			return Ok(Balances);
		}

		[HttpGet("{Id}")]
		public async ValueTask<ActionResult<Balance>> GetBalanceByIdAsync(Guid Id)
		{
			Balance gettingBalance = await this.balanceService.SelectBalanceByIdAsync(Id);

			return Ok(gettingBalance);
		}

		[HttpPut]
		public async ValueTask<ActionResult<Balance>> PutBalanceAsync(Balance Balance)
		{
			Balance updatedBalance = await this.balanceService.ModifyBalanceAsync(Balance);

			return Ok(updatedBalance);
		}

		[HttpDelete]
		public async ValueTask<ActionResult<Balance>> DeleteBalanceAsync(Guid Id)
		{
			Balance removedBalance = await this.balanceService.RemoveBalanceAsync(Id);

			return Ok(removedBalance);
		}
	}
}
