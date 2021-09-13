using System.Collections.Generic;

namespace BakeryManagementSystem.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string PasswordHash { get; set; }

        public string Email { get; set; }

        public string PhoneNo { get; set; }

        public string Address { get; set; }

        public string HashSalt { get; set; }
        
        public List<UserRole> UserRoles { get; set; }
    }
}