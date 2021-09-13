using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;
using BakeryManagementSystem.Context;
using System.Linq;
using System;

namespace BakeryManagementSystem.Interface
{
    public interface ICategoryRepository
    {
        public Category Add(Category categoty);

        public void Delete(int categotyId);

        public Category FindById(int categotyId);
  
        public Category Update(Category categoty);
    }
}