using BakeryManagementSystem.Models;
using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Context;
using System.Linq;
using System.Threading.Tasks;

using System;

namespace BakeryManagementSystem.Repositories
{
    public class PurchaceRepository : IPurchaceRepository
    {
        private readonly BakeryDbContext _dbContext;

        public PurchaceRepository(BakeryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Purchase Add(Purchase purchase)
        {
            _dbContext.Purchaces.Add(purchase);
            _dbContext.SaveChanges();
            return purchase;
        }

        public void Delete(int purchaseId)
        {
            var purchase = FindById(purchaseId);

            if (purchase != null)
            {
                _dbContext.Purchaces.Remove(purchase);
                _dbContext.SaveChanges();
            }
        }

        public Purchase FindById(int purchaseId)
        {
            return _dbContext.Purchaces.FirstOrDefault(u => u.Id.Equals(purchaseId));
        }

        public Purchase Update(Purchase purchace)
        {
            _dbContext.Purchaces.Update(purchace);
            _dbContext.SaveChanges();
            return purchace;
        }
    }
}