namespace RestaurantReviewApp.Models
{
    public class RestaurantCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
