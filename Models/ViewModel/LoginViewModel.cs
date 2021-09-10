using System.ComponentModel.DataAnnotations;

namespace BakeryManagementSystem.Models.ViewModel
{
    public class LoginViewModel
    {
        public string Email { get; set; }

        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name ="Password")]
        public string Password { get; set; }

    }
}