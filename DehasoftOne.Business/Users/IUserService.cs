using DehasoftOne.Entity.Users;

namespace DehasoftOne.Business.Users
{
    public interface IUserService
    {
        Task<User> AddUser(User user);
        Task<User> Authenticate(string username, string password);
        Task DeleteUser(Guid id);
        Task<User> GetUser(Guid id);
        Task<List<User>> GetUsers();
        Task UpdatePassword(Guid id, string password);
        Task UpdateUser(User user);
    }
}
