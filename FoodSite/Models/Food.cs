using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodSite.Models
{
    [Table("Foods")]
    public class Food
    {
        [Key]
        public int FoodId { get; set; }

        [Required(ErrorMessage = "Inform the food name")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "Min length is {0} and the max length is {1} char")]
        [Display(Name = "Food name")]
        public string FoodName { get; set; }

        [Required(ErrorMessage = "Inform the food short description")]
        [MinLength(20, ErrorMessage = "Description must have at least {1} char")]
        [MaxLength(200, ErrorMessage = "Description must have less than {1} char")]
        [Display(Name = "Food short description")]
        public string FoodShortDescription { get; set;}

        [Required(ErrorMessage = "Inform the food detailed description")]
        [MinLength(20, ErrorMessage = "Description must have at least {1} char")]
        [MaxLength(200, ErrorMessage = "Description must have less than {1} char")]
        [Display(Name = "Food detailed description")]
        public string FoodDetailedDescription { get; set;}

        [Required(ErrorMessage = "Inform the food price")]
        [Display(Name = "Food price")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99, ErrorMessage ="The price must be within 1 -- 999.99")]
        public decimal FoodPrice { get; set;}

        [Display(Name = "Normal image url")]
        [StringLength(200, ErrorMessage = "Max length is {1} char")]
        public string FoodImageUrl { get; set;}

        [Display(Name = "Thumb image url")]
        [StringLength(200, ErrorMessage = "Max length is {1} char")]
        public string FoodThumbUrl { get; set;}

        [Display(Name = "Favorite?")]
        public bool IsFavoriteFood { get; set;}

        [Display(Name = "In stock?")]
        public bool InStock {  get; set;}

        public int CategoryId { get; set;}
        public virtual Category Category { get; set;}

    }
}
