using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 characters.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters.")]
        [Compare("VerifyPassword", ErrorMessage = "Password does not match Confirm password.")]
        public string Password { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Confirm password required")]
        public string VerifyPassword { get; set; }

        public string Error { get; set; }
    }
}
