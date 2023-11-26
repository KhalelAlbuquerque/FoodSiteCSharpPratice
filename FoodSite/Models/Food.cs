namespace FoodSite.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string FoodShortDescription { get; set;}
        public string FoodDetailedDescription { get; set;}
        public decimal FoodPrice { get; set;}
        public string FoodImageUrl { get; set;}
        public string FoodThumbUrl { get; set;}
        public bool IsFavoriteFood { get; set;}
        public bool InStock {  get; set;}

        public int CategoryId { get; set;}
        public virtual Category Category { get; set;}

    }
}
