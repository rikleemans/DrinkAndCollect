using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndCollectV6.Models
{
    public class ReviewViewModel
    {
        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public int BeerID { get; set; }
        public int Rate { get; set; }
        public string Taste { get; set; }
        public string Description { get; set; }
        public DateTime Datum { get; set; }

        public ReviewViewModel()
        {
        }

        public ReviewViewModel(int reviewID, int userID, int beerID, int rate, string taste, string description, DateTime datum)
        {
            ReviewID = reviewID;
            UserID = userID;
            BeerID = beerID;
            Rate = rate;
            Taste = taste;
            Description = description;
            Datum = datum;
        }
    }
}
