using System;

namespace BakeryManagementSystem.Models
{
    public class Purchase : BaseEntity
    {
        public double Price { get; set; }
        public int Quantity { get; set; }
       

    }
}