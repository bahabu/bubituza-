using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bubituzagi.Models
{
    public class Post
    {
        public long Id { get; set; }


        [NotMapped]
        [DisplayName("Görsel")]
        public IFormFile? FormImage { get; set; }

        [Column(TypeName ="image")]
        public byte[]? Image { get; set; }
        

        [Column(TypeName = "nchar(50)")]
        [Required(ErrorMessage = "Bu alan gerekli")]
        [DisplayName("Başlık")]
        [StringLength(50, ErrorMessage = "En fazla 50 karaktere")]
        public string Title { get; set; }

        [DisplayName("Yazar")]
        public string AuthorId { get; set; } 



        [Column(TypeName = ("smalldatetime"))]
        public DateTime CreatedAt { get; set; } = DateTime.Now;


        [DisplayName("Katagori")]
        public short CatogryId { get; set; }

        [DisplayName("Önceki post")]
        public long? PreviousPostId { get; set; }

        public long? NextPostId { get; set; }
        public long Likes { get; set; }
        public long DisplayCount { get; set; }

        public bool deleted { get; set; }


        [Column(TypeName = "ntext")]
        [Required(ErrorMessage = "Bu alan gerekli")]
        [DisplayName("İçerik")]
        public string Content { get; set; }

        [DisplayName("Katagori")]
        [ForeignKey("CatogryId")]
        public Category? Catogory { get; set; }

        [DisplayName("Önceki post")]
        [ForeignKey("PreviousPostId")]
        public Post? PreviousPost { get; set; }

        [ForeignKey("NextPostId")]
        public Post? NextPost { get; set; }
        [DisplayName("Yazar")]
        [ForeignKey("AuthorId")]
        public ApplicationUser? Author { get; set; }

        [Column(TypeName ="nchar(100)")]
        [DisplayName("etiketler")]
        [StringLength(100,ErrorMessage ="En fazla 100 karakter")]
        public string? Tags { get; set; }

    }
}
