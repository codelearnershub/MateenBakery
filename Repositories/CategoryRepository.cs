using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;
using BakeryManagementSystem.Context;
using System.Linq;
using System;

namespace BakeryManagementSystem.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BakeryDbContext _dbContext;

        public CategoryRepository(BakeryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Category Add(Category categoty)
        {
            _dbContext.Categories.Add(categoty);
            _dbContext.SaveChanges();
            return categoty;
        }

        public void Delete(int categotyId)
        {
            var categoty = FindById(categotyId);

            if (categoty != null)
            {
                _dbContext.Categories.Remove(categoty);
                _dbContext.SaveChanges();
            }
        }

        public Category FindById(int categotyId)
        {
            return _dbContext.Categories.FirstOrDefault(u => u.Id.Equals(categotyId));

        }

        public Category Update(Category categoty)
        {
            _dbContext.Categories.Update(categoty);
            _dbContext.SaveChanges();
            return categoty;
        }
    }
}