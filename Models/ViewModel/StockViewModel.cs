using System;

namespace BakeryManagementSystem.Models.ViewModel
{
    public class StockViewModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
    }

    public class CreateStockViewModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
    }

    public class UpdateStockViewModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
    }
}