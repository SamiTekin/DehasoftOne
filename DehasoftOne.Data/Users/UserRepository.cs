using DehasoftOne.Data.Concrete;
using DehasoftOne.Data.Generics;
using DehasoftOne.Data.Tools;
using DehasoftOne.Entity.Users;

namespace DehasoftOne.Data.Users;

public class UserRepository : GenericRepository<User>
{
    public UserRepository(DehasoftOneDbContext dbContext) : base(dbContext)
    {
    }
    public new async Task<User> AddAsync(User user) 
    {
        user.Password = SaltyHashGenerator.GenerateSaltyHash(user.Password);
        return await base.AddAsync(user);
    }

    public new async Task UpdateAsync(User user)
    {
        user.Password=base.GetByIdAsync(user.Id).Result.Password;
        await base.UpdateAsync(user);
    }
    public async Task UpdatePassword(Guid id, string password)
    {
        User user = await base.GetByIdAsync(id);
        user.Password=SaltyHashGenerator.GenerateSaltyHash(password);
        await base.UpdateAsync(user);
    }

    public async Task<User> Authenticate(string username,string password)
    {
        return _dbContext.Users.Where(x => x.Username == username && x.Password == SaltyHashGenerator.GenerateSaltyHash(password)).FirstOrDefault();
    }
}
