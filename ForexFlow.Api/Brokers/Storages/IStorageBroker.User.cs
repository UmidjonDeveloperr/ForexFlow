using ForexFlow.Api.Models.Foundations.Users;

namespace ForexFlow.Api.Brokers.Storages
{
	public partial interface IStorageBroker
	{
		ValueTask<User> InsertUserAsync(User user);
		IQueryable<User> RetrieveAllUsers();
		ValueTask<User> RetrieveUserById(Guid Id);
		ValueTask<User> UpdateUserAsync(User user);
		ValueTask<User> DeleteUserAsync(User user);
	}
}
