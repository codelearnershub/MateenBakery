using System;
using System.Collections.Generic;
using System.IO;
namespace BakeryManagementSystem.Models
{
    public class Product : BaseEntity
    {
        public string ProductDescription {get; set;}
        public double ProductPrice {get; set;}
        public bool ProductAvailability {get; set;}
        public List<Category> Category {get; set;}
    }
}