using System;
namespace BakeryManagementSystem.Models
{
    public class Category : BaseEntity
    {
        public string Name {get; set;}

        public string Description {get; set;}
        public int UserId { get; set; }
    }
}