namespace RestaurantReviewApp.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }
        public DateTime VisitDate { get; set; }
        public Reviewer Reviewer { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
