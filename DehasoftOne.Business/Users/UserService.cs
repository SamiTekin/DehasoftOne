using DehasoftOne.Data.Users;
using DehasoftOne.Entity.Users;

namespace DehasoftOne.Business.Users;
public class UserService : IUserService
{
    private readonly UserRepository _userRepository;
    public UserService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> AddUser(User user)
    {
        return await _userRepository.AddAsync(user);
    }

    public async Task UpdateUser(User user)
    {
        await _userRepository.UpdateAsync(user);
    }

    public async Task DeleteUser(Guid id)
    {
        await _userRepository.DeleteAsync(id);
    }
    public async Task<List<User>> GetUsers()
    {
        return _userRepository.GetAll().ToList();
    }

    public async Task<User> GetUser(Guid id)
    {
        return await _userRepository.GetByIdAsync(id);
    }

    public async Task<User> Authenticate(string username, string password)
    {
        return await _userRepository.Authenticate(username, password);
    }

    public async Task UpdatePassword(Guid id, string password)
    {
        await _userRepository.UpdatePassword(id, password);
    }
}
