using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Jabeja.Models
{
    [Index(nameof(User.Username), IsUnique = true)]
    public class User : Account
    {
        
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Username { get; set; }
        public double? Stars { get; set; }

        public User()
        {
            
        }

    }
}
