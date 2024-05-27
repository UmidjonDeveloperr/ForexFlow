using ForexFlow.Api.Models.Foundations.Users;
using ForexFlow.Api.Services.Foundations.Users;
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace ForexFlow.Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class UserController : RESTFulController
	{
		private readonly IUserService userService;

		public UserController(IUserService userService)
		{
			this.userService = userService;
		}

		[HttpPost]
		public async ValueTask<ActionResult<User>> PostUserAsync(User user)
		{
			User postedUser = await this.userService.AddUserAsync(user);

			return Created(postedUser);
		}

		[HttpGet]
		public ActionResult<User> GetAllUsers()
		{
			IQueryable<User> users = this.userService.SelectAllUsers();

			return Ok(users);
		}

		[HttpGet("{Id}")]
		public async ValueTask<ActionResult<User>> GetUserByIdAsync(Guid Id)
		{
			User gettingUser = await this.userService.SelectUserById(Id);

			return Ok(gettingUser);
		}

		[HttpPut]
		public async ValueTask<ActionResult<User>> PutUserAsync(User user)
		{
			User updatedUser = await this.userService.ModifyUserAsync(user);

			return Ok(updatedUser);
		}

		[HttpDelete]
		public async ValueTask<ActionResult<User>> DeleteUserAsync(Guid Id)
		{
			User removedUser = await this.userService.RemoveUserAsync(Id);

			return Ok(removedUser);
		}
	}
}
