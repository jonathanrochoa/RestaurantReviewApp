using RestaurantReviewApp.Data;
using RestaurantReviewApp.Models;

namespace RestaurantReviewApp
{
    public class Seed
    {
        private readonly DataContext dataContext;

        public Seed(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public void SeedDataContext()
        {
            if (!dataContext.RestaurantCategories.Any())
            {
                var restaurantCategories = new List<RestaurantCategory>()
                {
                    new RestaurantCategory()
                    {
                        Restaurant = new Restaurant()
                        {
                            Name = "Jonny's Pizza",
                            Reviews = new List<Review>()
                            {
                                new Review() { Title = "Jonny's Pizza", Text = "Jonny's pizza is the best pizza in town", Rating = 9,
                                    Reviewer = new Reviewer() { FirstName = "Carolina", LastName = "Ochoa" } },
                                new Review() { Title = "Jonny's Pizza", Text = "It's not worth the hype", Rating = 6,
                                    Reviewer = new Reviewer() { FirstName = "Jake", LastName = "Bowen" } },
                                new Review() { Title = "Jonny's Pizza", Text = "Great pizza, will try again", Rating = 7,
                                    Reviewer = new Reviewer() { FirstName = "Anne", LastName = "Callum" } }
                            },
                            Locations = new List<Location>()
                            {
                                new Location() { Address = "4535 New Haven Court", City = "Rome", State = "Georgia" },
                                new Location() { Address = "154 Yellow Crest", City = "Rome", State = "Georgia" }
                            },
                            Menus = new List<Menu>()
                            {
                                new Menu() { Name = "Pizza Menu", ItemCategory = "Pizza", Item = "Pepperoni", Description = "Medium margarita pizza with pepperoni, oven baked", Cost = 15.45M },
                                new Menu() { Name = "Drinks Menu", ItemCategory = "Drinks", Item = "Fountain Soda", Description = "Large fountain soda", Cost = 2.51M },
                            }
                        },
                        Category = new Category()
                        {
                            Name = "Fast Food"
                        }
                    },
                    new RestaurantCategory()
                    {
                        Restaurant = new Restaurant()
                        {
                            Name = "Tacos El Paso",
                            Reviews = new List<Review>()
                            {
                                new Review()
                                {
                                    Title = "Tacos El Paso",
                                    Text = "Not worth the long wait",
                                    Rating = 5,
                                    Reviewer = new Reviewer() { FirstName = "Jesus", LastName = "Corona" }
                                },
                                new Review()
                                {
                                    Title = "Tacos El Paso",
                                    Text = "You HAVE to try their quesadillas",
                                    Rating = 8,
                                    Reviewer = new Reviewer() { FirstName = "James", LastName = "Morales" }
                                },
                                new Review()
                                {
                                    Title = "Tacos El Paso",
                                    Text = "Love their large selection of meats",
                                    Rating = 7,
                                    Reviewer = new Reviewer() { FirstName = "Silvia", LastName = "Jones" }
                                }
                            },
                            Locations = new List<Location>()
                            {
                                new Location() { Address = "1655 Kingston Circle", City = "Acworth", State = "Georgia" },
                            },
                            Menus = new List<Menu>()
                            {
                                new Menu() { Name = "Taco Menu", ItemCategory = "Tacos", Item = "Tacos al Pastor", Description = "3 Pastor beef, yellow corn tortillas, pineapple, onions, cilantro", Cost = 9.99M },
                                new Menu() { Name = "Drinks Menu", ItemCategory = "Drinks", Item = "Fresh Drinks", Description = "Mango juice", Cost = 4.00M },
                            }
                        },
                        Category = new Category()
                        {
                            Name = "Casual"
                        }
                    },
                    new RestaurantCategory()
                    {
                        Restaurant = new Restaurant()
                        {
                            Name = "Le Chemin",
                            Reviews = new List<Review>()
                            {
                                new Review()
                                {
                                    Title = "Chefs Kiss",
                                    Text = "Exactly the refined dining we needed",
                                    Rating = 10,
                                    Reviewer = new Reviewer() { FirstName = "Jon", LastName = "Stewart" }
                                },
                                new Review()
                                {
                                    Title = "Le Chemin",
                                    Text = "Signed up for waitlist and waited anxiously, the decor is beautiful and the food is good but the prices are absurdly high.",
                                    Rating = 7,
                                    Reviewer = new Reviewer() { FirstName = "Rose", LastName = "Labelle" }
                                },
                                new Review()
                                {
                                    Title = "Le Chemin",
                                    Text = "The food was delicious",
                                    Rating = 8,
                                    Reviewer = new Reviewer() { FirstName = "Joney", LastName = "McDermot" }
                                }
                            },
                            Locations = new List<Location>()
                            {
                                new Location() { Address = "336 8th Avenue", City = "Marietta", State = "Georgia" },
                            },
                            Menus = new List<Menu>()
                            {
                                new Menu() { Name = "Wine Menu", ItemCategory = "Wine", Item = "Malbec", Description = "2018 Malbec imported from Cahors, France", Cost = 26.50M },
                                new Menu() { Name = "Dessert Menu", ItemCategory = "Dessert", Item = "Chocolate Soufflé", Description = "Whipped egg whites incorporated with melted chocolate until just combined before being baked in individual ramekins", Cost = 32.00M },
                            }
                        },
                        Category = new Category()
                        {
                            Name = "Fine"
                        }
                    }
                };
                dataContext.RestaurantCategories.AddRange(restaurantCategories);
                dataContext.SaveChanges();
            }
        }
    }
}
