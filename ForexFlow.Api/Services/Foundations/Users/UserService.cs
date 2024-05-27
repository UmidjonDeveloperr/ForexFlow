//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using ForexFlow.Api.Brokers.Storages;
using ForexFlow.Api.Models.Foundations.Users;

namespace ForexFlow.Api.Services.Foundations.Users
{
	public partial class UserService : IUserService
	{
		private readonly IStorageBroker storageBroker;

		public UserService(IStorageBroker storageBroker)
		{
			this.storageBroker = storageBroker;
		}

		public async ValueTask<User> AddUserAsync(User user) =>
			await this.storageBroker.InsertUserAsync(user);

		public IQueryable<User> SelectAllUsers() =>
			this.storageBroker.RetrieveAllUsers();

		public async ValueTask<User> SelectUserByIdAsync(Guid Id) =>
			await this.storageBroker.RetrieveUserById(Id);

		public async ValueTask<User> ModifyUserAsync(User user) =>
			await this.storageBroker.UpdateUserAsync(user);

		public async ValueTask<User> RemoveUserAsync(Guid Id)
		{
			User gettingUser = await this.storageBroker.RetrieveUserById(Id);

			return await this.storageBroker.DeleteUserAsync(gettingUser);
		}
	}
}
