using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace bubituzagi.Models
{
    public class ApplicationUser:IdentityUser
    {

        
        [Column(TypeName ="nchar(100)")]
        [Required(ErrorMessage="Bu alan gereklidir")]
        [DisplayName("Ad soyad*")]
        [StringLength(100,MinimumLength =5,ErrorMessage ="En az 5 en fazla 100 karakter")]
        public string Name { get; set; }

        public bool Delete { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Bu alan gereklidir")]
        [DisplayName("şifre*")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "En az 5 en fazla 100 karakter")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Bu alan gereklidir")]
        [DisplayName("şifre tekrar*")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "En az 5 en fazla 100 karakter")]
        [Compare ("Password",ErrorMessage ="şifreler uyuşmuyor")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [NotMapped]
        [DisplayName("Üyelik sözleşmesini kabul ediyorum")]
        public bool Agreed { get; set; }


    }
}
