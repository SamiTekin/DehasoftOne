using DehasoftOne.Data.Concrete;
using DehasoftOne.Data.Generics;
using DehasoftOne.Entity.Products;

namespace DehasoftOne.Data.Products;

public class ProductRepository : GenericRepository<Product>
{
    public ProductRepository(DehasoftOneDbContext dbContext) : base(dbContext)
    {
    }
}
