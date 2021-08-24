using BakeryManagementSystem.Models;

namespace BakeryManagementSystem.Interface
{
    public interface IProductRepository
    {
        public Product Add(Product product);

        public void Delete(int productId);

        public Product FindById(int productId);

        public Product Update(Product product);
 
    }

}