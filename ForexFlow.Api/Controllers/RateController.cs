//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using ForexFlow.Api.Models.Foundations.Rates;
using ForexFlow.Api.Services.Processings.Rates;
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace ForexFlow.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RateController : RESTFulController
    {
        private readonly IRateProcessingService rateProcessingService;

        public RateController(IRateProcessingService rateProcessingService)
        {
            this.rateProcessingService = rateProcessingService;
        }

        [HttpGet]
        public async ValueTask<ActionResult<Rate>> GetAllRates()
        {
            Rate rate = await this.rateProcessingService.GetRatesAsync();

            return Ok(rate);
        }
    }
}
