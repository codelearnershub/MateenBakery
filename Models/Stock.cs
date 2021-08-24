using System;
using System.Collections.Generic;

namespace BakeryManagementSystem.Models
{
    public class Stock : BaseEntity
    {
        public int CategoryId { get; set; }
        public string Item  { get; set; }
        public int ProductId { get; set; }
        public double AvailableItem { get; set; }
        public List<SalesItem> SalesItems { get; set; }

    }
}