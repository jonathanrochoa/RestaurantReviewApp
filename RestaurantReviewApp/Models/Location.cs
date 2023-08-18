namespace RestaurantReviewApp.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Restaurant Restaurant { get; set; }  
    }
}
