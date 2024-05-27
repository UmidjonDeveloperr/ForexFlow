//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using ForexFlow.Api.Models.Foundations.Users;
using ForexFlow.Api.Services.Foundations.Users;

namespace ForexFlow.Api.Services.Processings.Users
{
    public class UserProcessingService : IUserProcessingService
    {
        private readonly IUserService userService;

        public UserProcessingService(IUserService userService) =>
            this.userService = userService;

        public async ValueTask<User> CreateUserAsync(User user)
        {
            user.Id = Guid.NewGuid();

            return await userService.AddUserAsync(user);
        }

        public bool EnsureUserAsync(string email, string password)
        {
            var user = userService.SelectAllUsers()
                .FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user is null)
                return false;
            else
                return true;
        }
    }
}
