﻿using ForexFlow.Api.Models.Foundations.Users;
using Microsoft.EntityFrameworkCore;
using STX.EFxceptions.SqlServer;

namespace ForexFlow.Api.Brokers.Storages
{
	public partial class StorageBroker : EFxceptionsContext, IStorageBroker
	{
		private readonly IConfiguration configuration;

		public StorageBroker(IConfiguration configuration)
		{
			this.configuration = configuration;
			Database.Migrate();
		}

		private async ValueTask<T> InsertAsync<T>(T @object) where T : class
		{
			using var broker = new StorageBroker(this.configuration);
			broker.Entry(@object).State = EntityState.Added;
			await broker.SaveChangesAsync();
			return @object;
		}

		private IQueryable<T> SelectAll<T>() where T : class
		{
			using var broker = new StorageBroker(this.configuration);
			return broker.Set<T>();
		}

		private async ValueTask<T> SelectAsync<T>(params object[] objectIds) where T : class
		{
			using var broker = new StorageBroker(this.configuration);

			return await broker.FindAsync<T>(objectIds);
		}

		private async ValueTask<T> UpdateAsync<T>(T @object) where T : class
		{
			using var broker = new StorageBroker(this.configuration);
			broker.Entry(@object).State = EntityState.Modified;
			await broker.SaveChangesAsync();

			return @object;
		}

		private async ValueTask<T> DeleteAsync<T>(T @object) where T : class
		{
			using var broker = new StorageBroker(this.configuration);
			broker.Entry(@object).State = EntityState.Deleted;
			await broker.SaveChangesAsync();

			return @object;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connectionString =
				this.configuration.GetConnectionString(name: "DefaultConnection");

			optionsBuilder.UseSqlServer(connectionString);
		}

		public override void Dispose()
		{ }
	}
}
