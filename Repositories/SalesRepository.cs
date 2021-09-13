using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;
using BakeryManagementSystem.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryManagementSystem.Repositories
{
    public class SalesRepository : ISalesRepository
    {
        private readonly BakeryDbContext _dbContext;

        public SalesRepository(BakeryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Sales Add(Sales sales)
        {
            _dbContext.Saless.Add(sales);
            _dbContext.SaveChanges();
            return sales;
        }

        public void Delete(int salesId)
        {
            var sales = FindById(salesId);

            if (sales != null)
            {
                _dbContext.Saless.Remove(sales);
                _dbContext.SaveChanges();
            }
        }

        public Sales FindById(int salesId)
        {
            return _dbContext.Saless.FirstOrDefault(u => u.Id.Equals(salesId));
        }

        public Sales Update(Sales sales)
        {
            _dbContext.Saless.Update(sales);
            _dbContext.SaveChanges();
            return sales;
        }
    }
}
