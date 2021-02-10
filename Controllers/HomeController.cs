using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            //The foreach is using the method created in Restaurant.cs and will display each restaurant info
            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                

                restaurantList.Add($"#{r.Rank}: {r.Name} | Favorite Dish: {r.FavoriteDish} | Address: {r.Address} | Phone Number: {r.Phone} | Website: {r.Website}");
            }

            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult EnterRestaurant()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterRestaurant(Suggestion appResponse)
        {
            //This if statement relates to the models
            if (ModelState.IsValid)
            {
                TempStorage.AddRestaurant(appResponse);
                return View("Confirmation", appResponse);
            }

            //If the data validations isn't valid, the user will be sent back to the EnterRestaurant page
            return View();
        }

        public IActionResult RestaurantList()
        {
            return View(TempStorage.Suggestions);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
