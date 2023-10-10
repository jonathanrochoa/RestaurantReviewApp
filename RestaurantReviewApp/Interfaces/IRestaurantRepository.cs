using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Interfaces
{
    public interface IRestaurantRepository
    {
        ICollection<Restaurant> GetRestaurants();
    }
}
