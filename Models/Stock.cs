namespace BakeryManagementSystem.Models
{
    public class Stock : BaseEntity
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

    }
}