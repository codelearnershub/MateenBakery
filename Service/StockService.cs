using System;
using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;

namespace BakeryManagementSystem.Service
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _stockRepository;
       
        public StockService(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public Stock Add(Stock stock)
        {
            stock = new Stock
            {
                CreatedAt = DateTime.Now,
                Item = stock.Item,
                CategoryId = stock.CategoryId,
                ProductId = stock.CategoryId
            };

            return _stockRepository.Add(stock);
        }

        public Stock FindById(int id)
        {
            return _stockRepository.FindById(id);
        }

        public Stock Update(int stockId, Stock stock)
        {
            stock = _stockRepository.FindById(stockId);
            if (stock == null)
            {
                return null;
            }

            stock.CategoryId = stock.CategoryId;
            stock.Item = stock.Item;
            stock.AvailableItem = stock.AvailableItem;
            stock.ProductId = stock.ProductId;
            stock.UpdatedAt = DateTime.Now;

            return _stockRepository.Update(stock);
        }

        public void Delete(int id)
        {
            _stockRepository.Delete(id);
        }
    }
}