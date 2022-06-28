using System.ComponentModel.DataAnnotations;

namespace AfsTest.Models.DTOs
{
    public class RegisterDTO
    {
        [Required(ErrorMessage="Username is required")]
        [Display(Name ="Username")]
        [MinLength(2,ErrorMessage ="Username field must be at least 2 characters")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Wrong Email address")]
        [Display(Name ="Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }   
        
       
    }
}
