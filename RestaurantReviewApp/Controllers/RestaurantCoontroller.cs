using Microsoft.AspNetCore.Mvc;
using RestaurantReviewApp.Interfaces;
using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class RestaurantCoontroller : ControllerBase
    {
        private readonly IRestaurantRepository _restaurantRepository;
        public RestaurantCoontroller(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Restaurant>))]
        public IActionResult GetRestaurants()
        {
            var restaurants = _restaurantRepository.GetRestaurants();

            if(!ModelState.IsValid)
                return BadRequest (ModelState);

            return Ok(restaurants);
        }

           
    }
}
