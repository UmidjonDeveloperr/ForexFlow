//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using ForexFlow.Api.Models.Foundations.Users;

namespace ForexFlow.Api.Services.Foundations.Users
{
	public interface IUserService
	{
		ValueTask<User> AddUserAsync(User user);
		IQueryable<User> SelectAllUsers();
		ValueTask<User> SelectUserByIdAsync(Guid Id);
		ValueTask<User> ModifyUserAsync(User user);
		ValueTask<User> RemoveUserAsync(Guid Id);
	}
}
