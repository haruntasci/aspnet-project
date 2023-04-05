using System.ComponentModel.DataAnnotations;

namespace AspNetCoreProject.Continue.Models
{
    public class RegisterViewModel : LoginViewModel
    {

        [Required(ErrorMessage = "Re-Password is required.")]
        [MinLength(6, ErrorMessage = "Re-Password can be min 6 characters.")]
        [MaxLength(16, ErrorMessage = "Re-Password can be max 16 characters.")]
        [Compare(nameof(Password))]
        public string RePassword { get; set; }
    }
}
