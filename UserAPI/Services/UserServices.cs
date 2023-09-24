using Microsoft.EntityFrameworkCore;
using UserAPI.Data;
using UserAPI.Data.Models;

namespace UserAPI.Services
{
    public class UserServices : IUserServices
    {
        private readonly UserDbContext _dbContext;

        public UserServices(UserDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> CreateUser(User request)
        {
            await _dbContext.UserTable.AddAsync(request);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<User>> GetUsers()
        {
            var user = await _dbContext.UserTable.ToListAsync();
            return user;
        }
    }
}
