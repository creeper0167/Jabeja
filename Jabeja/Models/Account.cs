using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Jabeja.Models
{

    public class Account
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        public string Name { get; set; }
        [Display(Name = "آدرس ایمیل")]
        [EmailAddress]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        public string Email { get; set; }
        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        public string Password { get; set; }

        [Display(Name= "شماره تلفن")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        public string? PhoneNumber { get; set; }
        [Display(Name = "تاریخ ساخت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime? CreatedDate { get; set; }

        [Display(Name="وضعیت اکانت")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        public bool IsActive { get; set; }
        public Account()
        {
            
        }

    }
}
