using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;
using BakeryManagementSystem.Context;
using System.Linq;
using System;

namespace BakeryManagementSystem.Interface
{
    public interface IPurchaceRepository
    {
        public Purchase Add(Purchase purchase);

        public void Delete(int purchaseId);

        public Purchase FindById(int purchaseId);
     
        public Purchase Update(Purchase purchace);
        
    }
}