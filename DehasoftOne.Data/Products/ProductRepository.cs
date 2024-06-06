using DehasoftOne.Data.Concrete;
using DehasoftOne.Data.Generics;
using DehasoftOne.Entity.Products;

namespace DehasoftOne.Data.Products;

public class ProductRepository : GenericRepository<Product>
{
    public ProductRepository(DehasoftOneDbContext dbContext) : base(dbContext)
    {
    }
    public async Task CheckQuantityAvailable(Guid productId, double quantity)
    {
        if(_dbContext.Set<Product>().FirstOrDefault(x => x.Id == productId).Quantity < quantity)
        {
            throw new Exception("Yetersiz Stok");
        }
    }
}
