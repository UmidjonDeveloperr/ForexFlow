//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using ForexFlow.Api.Models.Foundations.Users;
using ForexFlow.Api.Services.Processings.Users;
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace ForexFlow.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : RESTFulController
    {
        private readonly IUserProcessingService userProcessingService;

        public UserController(IUserProcessingService userProcessingService)
        {
            this.userProcessingService = userProcessingService;
        }

        [HttpPost]
        public async ValueTask<ActionResult<User>> Register(User user)
        {
            User postedUser =
                await this.userProcessingService.CreateUserAsync(user);

            return Created(postedUser);
        }

        [HttpGet]
        public ActionResult Login(string email, string password)
        {
            bool state =
                this.userProcessingService.EnsureUserAsync(email, password);

            if (state is true)
                return Ok();
            else
                return NotFound();
        }
    }
}
