using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class Restaurant
    {
        //This model is specifically for the top 5 restaurants that will be displayed on the home page

        //Rank is being set here so that the Rank model cannot be modified
        public Restaurant(int rank)
        {
            Rank = rank;
        }

        //Model created for all of the properties for a restaurant
        //Rank only has get method so it cannot be modified; does not have a set method, making it read only
        //The ? by the data types allows it to be nullable
        [Required]
        public int? Rank { get; }
        [Required]
        public string Name { get; set; }
        //Default message if nothing is put in for this field will be "It's all tasty!"
        public string FavoriteDish { get; set; } = "It's all tasty!";
        //[Required]
        public string Address { get; set; }
        [Phone]
        public string Phone { get; set; }
        //Default message if nothing is put in for this field will be "Coming soon"
        public string Website { get; set; } = "Coming soon";
        //I only added a ? for the int fields because if nothing is entered for a string, a null won't break the program, it will just enter in something empty


        public static Restaurant[] GetRestaurants()
        {
            //Creating top 5 restaurants to be displayed on home page
            Restaurant r1 = new Restaurant(1)
            {
                Name = "Bam Bams BBQ",
                FavoriteDish = "Brisket Sandwich Combo",
                Address = "1708 South State Street Orem, UT 84058",
                Phone = "801-225-1324",
                Website = "https://www.bambamsbbq.com/"
            };

            Restaurant r2 = new Restaurant(2)
            {
                Name = "Thai Evergreen",
                FavoriteDish = "Pad Thai",
                Address = "160 E University Pkwy, Orem, UT 84058",
                Phone = "801-221-3765",
                Website = "https://thaievergreenutah.com/"
            };

            Restaurant r3 = new Restaurant(3)
            {
                Name = "Seven Brothers",
                FavoriteDish = "Paniolo (cowboy)",
                Address = "4801 N University Ave #220, Provo, UT 84604",
                Phone = "385-477-4220",
                Website = "http://www.sevenbrothersburgers.com/"
            };

            Restaurant r4 = new Restaurant(4)
            {
                Name = "MidiCi The Neapolitan Pizza Company",
                FavoriteDish = "Egg N' Bacon",
                Address = "541 E University Pkwy B, Orem, UT 84097",
                Phone = "385-352-3752",
                Website = "https://mymidici.com/"
            };

            Restaurant r5 = new Restaurant(5)
            {
                //Favorite dish is not included in this entry so the default input "It's all tasty!" from above is used.
                Name = "Don Joaquin Street Tacos",
                Address = "150 W 1230 N St, Provo, UT 84604",
                Phone = "801-400-2894",
                Website = "https://stdonjoaquin.com/"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
