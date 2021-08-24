using BakeryManagementSystem.Models;

namespace BakeryManagementSystem.Interface
{
    public interface ICategoryService
    {
        public Category Add(Category category);

        public Category FindById(int id);

        public Category Update(int categoryId, Category category);

        public void Delete(int id);
    }
}