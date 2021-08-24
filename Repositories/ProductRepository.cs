using System.Linq;
using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Context;
using BakeryManagementSystem.Models;

namespace BakeryManagementSystem.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly BakeryDbContext _dbContext;

        public ProductRepository(BakeryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Product Add(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product;
        }

        public void Delete(int productId)
        {
            var product = FindById(productId);

            if (product != null)
            {
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
            }
        }

        public Product FindById(int productId)
        {
            return _dbContext.Products.FirstOrDefault(u => u.Id.Equals(productId));
        }

        public Product Update(Product product)
        {
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            return product;
        }
    }
}