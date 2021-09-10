using System;
using System.Collections.Generic;

namespace BakeryManagementSystem.Models
{
    public class UserRole  : BaseEntity
    {
        public int RoleId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public Role Role { get; set; }


    }
}