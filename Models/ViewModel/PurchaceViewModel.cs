using System;

namespace BakeryManagementSystem.Models.ViewModel
{
    public class PurchaceViewModel
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime dateTime { get; set; }

    }

    public class CreatePurchaceViewModel
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime dateTime { get; set; }
    }

    public class UpdatePurchaceViewModel
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime dateTime { get; set; }
    }
}