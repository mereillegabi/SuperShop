using System.ComponentModel.DataAnnotations;

namespace SuperShop.Models
{
    public class RecoverPasswordViewModel
    {

        [Required]
        [EmailAddress]
        public string Email { get; set; }


        public string Password { get; set; }
    }
}