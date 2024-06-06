using DehasoftOne.Data.Concrete;
using DehasoftOne.Data.Generics;
using DehasoftOne.Entity.Customer;

namespace DehasoftOne.Data.Customers;

public class CustomerRepository : GenericRepository<Customer>
{
    public CustomerRepository(DehasoftOneDbContext dbContext) : base(dbContext)
    {
    }
}
