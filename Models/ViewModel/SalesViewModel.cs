using System;

namespace BakeryManagementSystem.Models.ViewModel
{
    public class SalesViewModel
    {
        public int Id { get; set; }

        public string ListOfSalesItem { get; set; }

        public string MadeBy { get; set; }

        public double TotalSalesPrice { get; set; }
    }

    public class CreateSalesViewModel
    {
        public int Id { get; set; }

        public string ListOfSalesItem { get; set; }

        public string MadeBy { get; set; }

        public double TotalSalesPrice { get; set; }
    }

    public class UpdateSalesViewModel
    {
        public int Id { get; set; }

        public string ListOfSalesItem { get; set; }

        public string MadeBy { get; set; }

        public double TotalSalesPrice { get; set; }
    }
}