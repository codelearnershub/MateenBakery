using System;

namespace BakeryManagementSystem.Models.ViewModel
{
    public class CategoryViewModel
    {
        public int Id {get; set;}
        public string CategoryName {get; set;}
        public string CategoryDescription {get; set;}
    }

    public class CreateCategoryViewModel
    {
        public int Id {get; set;}
        public string CategoryName {get; set;}
        public string CategoryDescription {get; set;}
    }

    public class UpdateCategoryViewModel
    {
        public int Id {get; set;}
        public string CategoryName {get; set;}
        public string CategoryDescription {get; set;}
    }
}