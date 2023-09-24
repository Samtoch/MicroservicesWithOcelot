using Microsoft.EntityFrameworkCore;
using ProductAPI.Data.Models;
using UserAPI.Data;

namespace ProductAPI.Services
{
    public class ProductServices : IProductServices
    {
        private readonly ProductDbContext _dbContext;
        public ProductServices(ProductDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task<bool> CreateProduct(Product request)
        {
            await _dbContext.Products.AddAsync(request);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Product>> GeProducts()
        {
            var product = await _dbContext.Products.ToListAsync();
            return product;
        }
    }
}
