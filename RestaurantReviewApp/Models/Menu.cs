namespace RestaurantReviewApp.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ItemCategory { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
