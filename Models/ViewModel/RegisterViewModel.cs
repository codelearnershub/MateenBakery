using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BakeryManagementSystem.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage="Fill out this field")]
        [Display(Name ="Name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Phone No")]
        public string Phone { get;  set; }
        
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Address")]
        public string Address { get;set; }
        
        public List<Role> Roles { get; set; } 
    }
}