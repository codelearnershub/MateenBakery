using BakeryManagementSystem.Models;

namespace BakeryManagementSystem.Interface
{
    public interface ISalesService
    {
        public Sales Add(Sales sales);
     

        public Sales FindById(int id);
       

        public Sales Update(int salesId, Sales sales);


        public void Delete(int id);

    }
}