using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class Suggestion
    {
        //Suggestion is a model that handles restaurants suggested by people visiting the site that were not included in the top 5
        //I did not make any fields required or do any other data validation (besides the phone) because the instructions did not specifically say to do so 

        public string Name { get; set; }
        public string RestaurantName { get; set; }
        public string FavoriteDish { get; set; }
        //Data validation is phone - this is also reflected in the phone input on EnterRestaurant.cshtml
        [Phone]
        public string RestaurantPhone { get; set; }
    }
}
