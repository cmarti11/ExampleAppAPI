using ExampleAppAPI.API.Data.Models;

namespace ExampleAppAPI.API.Services
{
    public interface IUserService
    {
        Task<User>? GetUserAsync(string username, string password);
    }
}
