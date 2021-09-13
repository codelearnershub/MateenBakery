using BakeryManagementSystem.Models;

namespace BakeryManagementSystem.Interface
{
    public interface IPurchaceService
    {
        public Purchase Add(Purchase purchase);
        
        public Purchase FindById(int id);
        

        public Purchase Update(int PurchaseId, Purchase purchase);
        
        public void Delete(int id);

    }
}