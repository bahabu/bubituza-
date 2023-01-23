using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace bubituzagi.Models
{
    public class TopCategory
    {

        public short Id { get; set; }

        [Column(TypeName = "nchar(50)")]
        [Required(ErrorMessage = "Bu alan gerekli")]
        [DisplayName("İsim")]
        [StringLength(50, ErrorMessage = "En fazla 50 karaktere")]
        public string Name { get; set; }
        public List<Category>? Categories { get; set; }
    }
}
