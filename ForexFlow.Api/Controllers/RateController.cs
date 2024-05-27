//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using ForexFlow.Api.Models.Foundations.Rates;
using ForexFlow.Api.Services.Foundations.Rates;
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace ForexFlow.Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class RateController : RESTFulController
	{
		private readonly IRateService rateService;

		public RateController(IRateService rateService)
		{
			this.rateService = rateService;
		}

		[HttpPost]
		public async ValueTask<ActionResult<Rate>> PostRateAsync(Rate Rate)
		{
			Rate postedRate = await this.rateService.AddRateAsync(Rate);

			return Created(postedRate);
		}

		[HttpGet]
		public ActionResult<Rate> GetAllRates()
		{
			IQueryable<Rate> Rates = this.rateService.SelectAllRates();

			return Ok(Rates);
		}

		[HttpGet("{Id}")]
		public async ValueTask<ActionResult<Rate>> GetRateByIdAsync(Guid Id)
		{
			Rate gettingRate = await this.rateService.SelectRateByIdAsync(Id);

			return Ok(gettingRate);
		}

		[HttpPut]
		public async ValueTask<ActionResult<Rate>> PutRateAsync(Rate Rate)
		{
			Rate updatedRate = await this.rateService.ModifyRateAsync(Rate);

			return Ok(updatedRate);
		}

		[HttpDelete]
		public async ValueTask<ActionResult<Rate>> DeleteRateAsync(Guid Id)
		{
			Rate removedRate = await this.rateService.RemoveRateAsync(Id);

			return Ok(removedRate);
		}
	}
}
