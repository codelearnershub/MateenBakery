using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;
using System;

namespace BakeryManagementSystem.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category Add(Category category)
        {
            category = new Category
            {
                CreatedAt = DateTime.Now,
                Description = category.Description,
                Name = category.Name
            };

            return _categoryRepository.Add(category);
        }

        public Category FindById(int id)
        {
            return _categoryRepository.FindById(id);
        }

        public Category Update(int categoryId, Category category)
        {
            category = _categoryRepository.FindById(categoryId);
            if (category == null)
            {
                return null;
            }

            category.Description = category.Description;
            category.Name = category.Name;
            category.UpdatedAt = DateTime.Now;

            return _categoryRepository.Update(category);
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }
    }
 
}