using System;
using System.Collections.Generic;


namespace BakeryManagementSystem.Models.ViewModel
{
    public class ProductViewModel
    {
        public int Id {get; set;}
        public string ProductDescription {get; set;}
        public double ProductPrice {get; set;}
        public bool ProductAvailability {get; set;}
        public List<Category> Category {get; set;}
    }

    public class CreateProductViewModel
    {
        public int Id {get; set;}
        public string ProductDescription {get; set;}
        public double ProductPrice {get; set;}
        public bool ProductAvailability {get; set;}
        public List<Category> Category {get; set;}
    }

    public class UpdateProductViewModel
    {
        public int Id {get; set;}
        public string ProductDescription {get; set;}
        public double ProductPrice {get; set;}
        public bool ProductAvailability {get; set;}
        public List<Category> Category {get; set;}
    }
}