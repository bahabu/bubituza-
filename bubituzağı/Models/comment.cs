using bubituzagi.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace bubituzagi.Models
{
    public class comment
    {
        public long Id { get; set; }


        [Column(TypeName ="nchar(256)")]
        [Required(ErrorMessage ="Bu alan gerekli")]
        [StringLength(256,ErrorMessage ="En fazla 256 karakter")]
        [DisplayName("içerik")]
        public string Content { get; set; }

        [Column(TypeName ="smalldatetime")]
        public DateTime TimeSpan { get; set; }


        [DisplayName("Post")]
        public long PostId { get; set; }

        [DisplayName("Post")]
        [ForeignKey("PostId")]
        public Post? Post { get; set; }



    }
}
