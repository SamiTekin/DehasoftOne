using DehasoftOne.Data.Products;
using DehasoftOne.Entity.Products;

namespace DehasoftOne.Business.Products;

public class ProductService : IProductService
{
    private readonly ProductRepository _productRepository;
    public ProductService(ProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> AddProduct(Product product)
    {
        return await _productRepository.AddAsync(product);
    }

    public async Task UpdateProduct(Product product)
    {
        await _productRepository.UpdateAsync(product);
    }

    public async Task DeleteProduct(Guid id)
    {
        await _productRepository.DeleteAsync(id);
    }
    public async Task<List<Product>> GetProducts()
    {
        return _productRepository.GetAll().ToList();
    }

    public async Task<Product> GetProduct(Guid id)
    {
        return await _productRepository.GetByIdAsync(id);
    }
}
