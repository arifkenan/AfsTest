using AfsTest.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace AfsTest.Models.DTOs
{
    public class UserUpdateDTO
    {
        [Required(ErrorMessage ="Username can't be empty")]
        [Display(Name ="Username")]
        [MinLength(3,ErrorMessage ="Must be more than 3 chararacters")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password can't be empty")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="Email can't be empty")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Email is not valid")]
        [Display(Name ="Email")]
        public string Email { get; set; }

        public UserUpdateDTO()
        {

        }
        public UserUpdateDTO(AppUser user)
        {
            UserName = user.UserName;
            Password = user.PasswordHash;
            Email = user.Email;
        }

    }
}
