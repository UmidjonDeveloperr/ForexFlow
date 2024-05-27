using ForexFlow.Api.Models.Foundations.Users;

namespace ForexFlow.Api.Services.Foundations.Users
{
	public interface IUserService
	{
		ValueTask<User> AddUserAsync(User user);
		IQueryable<User> SelectAllUsers();
		ValueTask<User> SelectUserById(Guid Id);
		ValueTask<User> ModifyUserAsync(User user);
		ValueTask<User> RemoveUserAsync(Guid Id);
	}
}
