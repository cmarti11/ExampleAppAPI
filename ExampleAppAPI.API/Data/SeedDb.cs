﻿using Microsoft.EntityFrameworkCore;

namespace ExampleAppAPI.API.Data
{
    public class SeedDb
    {
        private readonly ExampleAppAPIAPIContext context;
        private readonly Random random;

        public SeedDb(ExampleAppAPIAPIContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Client.Any())
            {
                this.AddClient("First Client");
                this.AddClient("Second Client");
                this.AddClient("Third Client");
                await this.context.SaveChangesAsync();
            }

            await this.context.Database.MigrateAsync();
        }

        private void AddClient(string name)
        {
            this.context.Client.Add(new Models.Client
            {
                Name = name,
                Dna = this.random.Next(1000000,1999999).ToString()
            });
        }

    }
}
