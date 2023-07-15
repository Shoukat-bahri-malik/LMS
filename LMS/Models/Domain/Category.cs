using System.ComponentModel.DataAnnotations;

namespace LMS.Models.Domain
{
    public class Category
    {

        [Key]
   
        public int CategoryId { get; set; }

        [Display(Name ="Category Name")]
        [Required(ErrorMessage ="enter category name .its required")]
        [StringLength(30,MinimumLength =5,ErrorMessage ="enter min 5 char for category")]
        public string Name { get; set; }
    }
}
