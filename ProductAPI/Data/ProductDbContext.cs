using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ProductAPI.Data.Models;

namespace UserAPI.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
