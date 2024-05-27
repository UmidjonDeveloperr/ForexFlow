//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using ForexFlow.Api.Models.Foundations.Users;
using Microsoft.EntityFrameworkCore;

namespace ForexFlow.Api.Brokers.Storages
{
	public partial class StorageBroker
	{
		public DbSet<User> Users { get; set; }

		public async ValueTask<User> InsertUserAsync(User user) =>
			await InsertAsync(user);

		public IQueryable<User> RetrieveAllUsers() =>
			SelectAll<User>();

		public async ValueTask<User> RetrieveUserById(Guid Id) =>
			await SelectAsync<User>(Id);

		public async ValueTask<User> UpdateUserAsync(User user) =>
			await UpdateAsync(user);

		public async ValueTask<User> DeleteUserAsync(User user) =>
			await DeleteAsync(user);
	}
}
