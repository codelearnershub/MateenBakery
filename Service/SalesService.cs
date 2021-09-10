using System;
using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;

namespace BakeryManagementSystem.Service
{
    public class SalesService : ISalesService
    {
        private readonly ISalesRepository _salesRepository;
       
        public SalesService(ISalesRepository salesRepository)
        {
            _salesRepository = salesRepository;
        }

        public Sales Add(Sales sales)
        {
            sales = new Sales
            {
                CreatedAt = DateTime.Now,
                Item = sales.Item,
                ListOfSalesItem = sales.ListOfSalesItem,
                TotalSalesPrice = sales.TotalSalesPrice,
            };

            return _salesRepository.Add(sales);
        }

        public Sales FindById(int id)
        {
            return _salesRepository.FindById(id);
        }

        public Sales Update(int salesId, Sales sales)
        {
            sales = _salesRepository.FindById(salesId);
            if (sales == null)
            {
                return null;
            }

            sales.Item = sales.Item;
            sales.TotalSalesPrice = sales.TotalSalesPrice;
            sales.ListOfSalesItem = sales.ListOfSalesItem;
            sales.UpdatedAt = DateTime.Now;

            return _salesRepository.Update(sales);
        }

        public void Delete(int id)
        {
            _salesRepository.Delete(id);
        }
    }
}