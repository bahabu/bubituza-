using bubituzagi.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bubituzagi.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short Id { get; set; }

        [Column(TypeName ="nchar(50)")]
        [Required(ErrorMessage = "Bu alan gerekli")]
        [DisplayName("İsim")]
        [StringLength(50, ErrorMessage = "En fazla 50 karaktere")]
        public string Name { get; set; }

        [Column(TypeName = "nchar(100)")]
        [Required(ErrorMessage = "Bu alan gerekli")]
        [DisplayName("Bilgi")]
        [StringLength(100, ErrorMessage = "En fazla 100 karaktere")]
        public string? Info { get; set; }

        [DisplayName("Ana katogori")]
        public short? TopCategoryId { get; set; }


        [ForeignKey(nameof(TopCategoryId))]
        [DisplayName("Ana katogori")]
        public TopCategory? TopCategory { get; set; }
        
    }
}

