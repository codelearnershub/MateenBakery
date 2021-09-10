using System;
using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;

namespace BakeryManagementSystem.Service
{
    public class SalesItemService : ISalesItemService
    {
        private readonly ISalesItemRepository _salesItemRepository;
       
        public SalesItemService(ISalesItemRepository salesItemRepository)
        {
            _salesItemRepository = salesItemRepository;
        }

        public SalesItem Add(SalesItem salesItem)
        {
            salesItem = new SalesItem
            {
                CreatedAt = DateTime.Now,
                Item = salesItem.Item,
                NoOfItem = salesItem.NoOfItem,
                StockId = salesItem.StockId,
                SalesId = salesItem.SalesId,
                PricePerItem = salesItem.PricePerItem
            };

            return _salesItemRepository.Add(salesItem);
        }

        public SalesItem FindById(int id)
        {
            return _salesItemRepository.FindById(id);
        }

        public SalesItem Update(int SalesItemId, SalesItem salesItem)
        {
            salesItem = _salesItemRepository.FindById(SalesItemId);
            if (salesItem == null)
            {
                return null;
            }

            salesItem.Item = salesItem.Item;
            salesItem.NoOfItem = salesItem.NoOfItem;
            salesItem.PricePerItem = salesItem.PricePerItem;
            salesItem.UpdatedAt = DateTime.Now;

            return _salesItemRepository.Update(salesItem);
        }
       
        public void Delete(int id)
        {
            _salesItemRepository.Delete(id);
        }
    }
}