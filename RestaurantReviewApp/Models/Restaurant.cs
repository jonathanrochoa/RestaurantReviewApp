namespace RestaurantReviewApp.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Review> Reviews { get; set;}
        public ICollection<Location> Locations { get; set; }
        public ICollection<Menu> Menus { get; set; }
        public Category Category { get; set; }
        public ICollection<RestaurantCategory> RestaurantCategories { get; set;}
    }
}
