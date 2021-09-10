using System;
using BakeryManagementSystem.Models;

namespace BakeryManagementSystem
{
    public interface IProductService
    {
        public Product Add(Product product);
        public Product FindById(int id);
        public Product Update(int ProductId, Product product);
        public void Delete(int id);
    }
}