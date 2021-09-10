namespace BakeryManagementSystem.Models
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        
        public User UserId { get; set; }

    }
}