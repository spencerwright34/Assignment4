using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public static class TempStorage
    {
        //This is to store the restaurant info temporarily while the app is running
        //The storage will clear when the app stops
        private static List<Suggestion> suggestions = new List<Suggestion>();

        public static IEnumerable<Suggestion> Suggestions => suggestions;
        public static void AddRestaurant(Suggestion suggestion)
        {
            suggestions.Add(suggestion);
        }
    }
}
