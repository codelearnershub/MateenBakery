using System;
using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;

namespace BakeryManagementSystem.Service
{
    public class PurchaceService : IPurchaceService
    {
        private readonly IPurchaceRepository _purchaceRepository;
       
        public PurchaceService(IPurchaceRepository purchaceRepository)
        {
            _purchaceRepository = purchaceRepository;
        }

        public Purchase Add(Purchase purchase)
        {
            purchase = new Purchase
            {
                CreatedAt = DateTime.Now,
                Price = purchase.Price,
                Quantity = purchase.Quantity
            };

            return _purchaceRepository.Add(purchase);
        }


        public Purchase FindById(int id)
        {
            return _purchaceRepository.FindById(id);
        }

        public Purchase Update(int PurchaseId, Purchase purchase)
        {
            purchase = _purchaceRepository.FindById(PurchaseId);
            if (purchase == null)
            {
                return null;
            }

            purchase.Price = purchase.Price;
            purchase.Quantity = purchase.Quantity;
            purchase.UpdatedAt = DateTime.Now;

            return _purchaceRepository.Update(purchase);
        }
       
        public void Delete(int id)
        {
            _purchaceRepository.Delete(id);
        }
    }
}