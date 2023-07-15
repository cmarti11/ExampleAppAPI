using ExampleAppAPI.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleAppAPI.API.Data
{
    public class ExampleAppAPIAPIContext : DbContext
    {
        public ExampleAppAPIAPIContext(DbContextOptions<ExampleAppAPIAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; } = default!;
    }
}
