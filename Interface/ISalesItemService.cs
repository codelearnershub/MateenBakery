using BakeryManagementSystem.Models;

namespace BakeryManagementSystem.Interface
{
    public interface ISalesItemService
    {
        public SalesItem Add(SalesItem salesItem);
        
        public SalesItem FindById(int id);
               
        public SalesItem Update(int SalesItemId, SalesItem salesItem);

        public void Delete(int id);

    }
}
    
    