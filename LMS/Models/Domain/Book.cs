using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Models.Domain
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required(ErrorMessage = "please enter title .its required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "please enter  author name .its required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "please enter min three character for title.")]
        public string AuotherName { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "please enter error message. its required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "please enter min three character for title.")]
        public DateTime RelaseDate { get; set; }

        public string Rating { get; set; }

        [Display(Name ="Category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public  virtual Category ? Categories { get; set; }
    }
}
