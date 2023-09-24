using UserAPI.Data.Models;

namespace UserAPI.Services
{
    public interface IUserServices
    {
        Task<List<User>> GetUsers();
        Task<bool> CreateUser(User request);
    }
}
