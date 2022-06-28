using System.ComponentModel.DataAnnotations;

namespace AfsTest.Models.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage="Username is required")]
        [Display(Name ="Username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
