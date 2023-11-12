using Microsoft.EntityFrameworkCore;
using ShopeOnline.Api.Entities;
using Shoponline.Api.Data;
using Shoponline.Api.Repositories.Contracts;
using System.Diagnostics;

namespace Shoponline.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopOnlineDbContext shopOnlineDbContext;

        public ProductRepository(ShopOnlineDbContext shopOnlineDbContext)
        {
            this.shopOnlineDbContext = shopOnlineDbContext;
        }

        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.shopOnlineDbContext.ProductCategories.ToListAsync();

            return (IEnumerable<ProductCategory>)categories;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.shopOnlineDbContext.Products.ToListAsync();
            return products;
        }
    }
}
