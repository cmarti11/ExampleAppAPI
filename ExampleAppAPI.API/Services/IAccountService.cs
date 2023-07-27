using ExampleAppAPI.API.Data.Models;

namespace ExampleAppAPI.API.Services
{
    public interface IAccountService
    {
        string GenerateJwtToken(User user);
    }
}
