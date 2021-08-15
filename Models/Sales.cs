namespace BakeryManagementSystem.Models
{
    public class Sales : BaseEntity
    {
        public string ListOfSalesItem { get; set; }

        public string MadeBy { get; set; }

        public double TotalSalesPrice { get; set; }
    }
}