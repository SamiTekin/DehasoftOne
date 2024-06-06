using DehasoftOne.Entity.Products;

namespace DehasoftOne.Business.Products
{
    public interface IProductService
    {
        Task<Product> AddProduct(Product product);
        Task DeleteProduct(Guid id);
        Task<Product> GetProduct(Guid id);
        Task<List<Product>> GetProducts();
        Task UpdateProduct(Product product);
    }
}