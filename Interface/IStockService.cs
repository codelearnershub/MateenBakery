using System;
using BakeryManagementSystem.Models;

namespace BakeryManagementSystem
{
    public interface IStockService
    {
        public Stock Add(Stock stock);
        public Stock FindById(int id);
        public Stock Update(int stockId, Stock stock);
        public void Delete(int id);
    }
}