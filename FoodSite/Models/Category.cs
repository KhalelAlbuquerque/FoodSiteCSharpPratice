using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodSite.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required (ErrorMessage = "Inform the category name")]
        [StringLength(100, ErrorMessage = "Max length is 100 char")]
        [Display(Name = "Name")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Inform the category description")]
        [StringLength(200, ErrorMessage = "Max length is 200 char")]
        [Display(Name = "Description")]
        public string CategoryDescription { get; set; }

        public List<Food> Foods { get; set; }
    }
}
