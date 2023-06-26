using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExampleAppAPI.API.Data.Models;

namespace ExampleAppAPI.API.Data
{
    public class ExampleAppAPIAPIContext : DbContext
    {
        public ExampleAppAPIAPIContext (DbContextOptions<ExampleAppAPIAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ExampleAppAPI.API.Data.Models.User> User { get; set; } = default!;
    }
}
