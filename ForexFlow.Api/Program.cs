//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using ForexFlow.Api.Brokers.Storages;
using ForexFlow.Api.Services.Foundations.Users;

internal class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);
		builder.Services.AddControllers();
		builder.Services.AddDbContext<StorageBroker>();
		AddBrokers(builder);
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen();
		builder.Services.AddTransient<IUserService, UserService>();
		var app = builder.Build();

		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		}

		app.UseHttpsRedirection();
		app.UseAuthorization();
		app.MapControllers();
		app.Run();
	}

	private static void AddBrokers(WebApplicationBuilder builder)
	{
		builder.Services.AddTransient<IStorageBroker, StorageBroker>();
	}
}
