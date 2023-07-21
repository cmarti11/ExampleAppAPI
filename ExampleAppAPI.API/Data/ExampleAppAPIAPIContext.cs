﻿using ExampleAppAPI.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleAppAPI.API.Data
{
    public class ExampleAppAPIAPIContext : DbContext
    {
        public ExampleAppAPIAPIContext(DbContextOptions<ExampleAppAPIAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable(nameof(Client));
            modelBuilder.Entity<UserRole>().ToTable(nameof(UserRole));
            modelBuilder.Entity<User>().ToTable(nameof(User));

            base.OnModelCreating(modelBuilder);
        }
    }
}
