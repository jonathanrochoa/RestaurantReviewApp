using RestaurantReviewApp.Data;
using RestaurantReviewApp.Interfaces;
using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly DataContext _context;
        public RestaurantRepository(DataContext context) 
        { 
            _context = context;
        }

        public ICollection<Restaurant> GetRestaurants() 
        {
            return _context.Restaurants.OrderBy(r => r.Id).ToList();
        }
    }
}
