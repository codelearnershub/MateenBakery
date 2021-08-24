using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Context;
using BakeryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryManagementSystem.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly BakeryDbContext _dbContext;

        public StockRepository(BakeryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Stock Add(Stock stock)
        {
            _dbContext.Stocks.Add(stock);
            _dbContext.SaveChanges();
            return stock;
        }

        public void Delete(int stockId)
        {
            var stock = FindById(stockId);

            if (stock != null)
            {
                _dbContext.Stocks.Remove(stock);
                _dbContext.SaveChanges();
            }
        }

        public Stock FindById(int stockId)
        {
            return _dbContext.Stocks.FirstOrDefault(u => u.Id.Equals(stockId));
        }

        public Stock Update(Stock stock)
        {
            _dbContext.Stocks.Update(stock);
            _dbContext.SaveChanges();
            return stock;
        }
    }
}
