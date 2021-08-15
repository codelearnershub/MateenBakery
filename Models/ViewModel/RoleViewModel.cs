using System;

namespace BakeryManagementSystem.Models.ViewModel
{
    public class RoleViewModel
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public string Description { get; set; }
    }

    public class CreateRoleViewModel
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public string Description { get; set; }
    }
}