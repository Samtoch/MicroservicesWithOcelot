using ProductAPI.Data.Models;

namespace ProductAPI.Services
{
    public interface IProductServices
    {
        Task<List<Product>> GeProducts();
        Task<bool> CreateProduct(Product request);
    }
}
