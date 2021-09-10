using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BakeryManagementSystem.Models;

namespace CarRentalsSystem.Models
{
    public class RoleViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public class CreateRoleViewModel 
    {
        public int Id { get; set; }
        [Required(ErrorMessage="This field is required")]
        [DisplayName("Name")]
        public string Name { get; set; }
    }
    public class UpdateRoleViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="This field is required")]
        [DisplayName("Name")]
        public string Name { get; set; }
    }
}