//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================


//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using ForexFlow.Api.Models.Foundations.Users;

namespace ForexFlow.Api.Services.Processings.Users
{
    public interface IUserProcessingService
    {
        bool EnsureUserAsync(string email, string password);
        ValueTask<User> CreateUserAsync(User user);
    }
}
