using Microsoft.AspNetCore.Mvc;
using OdeToFood.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.View
{
    public class RestaurantCount : ViewComponent
    {
        private readonly IRestaurantData restaurantData;
        public RestaurantCount(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }       

        public IViewComponentResult Invoke()
        {
            var count = restaurantData.GetCountOfRestaurant();

            return View(count);
        }
    }
}
