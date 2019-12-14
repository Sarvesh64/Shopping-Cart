using Website.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.Data.Models;
using Microsoft.EntityFrameworkCore;
using Website.Data;

namespace Website.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Product> Products => _appDbContext.Products.Include(c => c.Category);

        public IEnumerable<Product> PreferredProducts => _appDbContext.Products.Where(p => p.IsPreferredProduct).Include(c => c.Category);

        public Product GetProductById(int productId) => _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
    }
}
