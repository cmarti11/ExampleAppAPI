using ExampleAppAPI.API.Data;
using ExampleAppAPI.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleAppAPI.API.Services
{
    public class UserService : IUserService
    {

        private readonly ExampleAppAPIAPIContext _context;


        public UserService(ExampleAppAPIAPIContext context)
        {
            _context = context;
        }

        public async Task<User>? GetUserAsync(string username, string password)
        {
            if (_context.Users == null)
            {
                return null;
            }
            var user = await _context.Users.FirstOrDefaultAsync(user => user.UserName == username && user.Password == password);

            return user;
        }
    }
}
