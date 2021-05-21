using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndCollectV4.Models
{
    public partial class ReviewViewModel
    {
        [Required]
        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public int BeerID { get; set; }
        public int Rate { get; set; }
        public string Taste { get; set; }
        public string Description { get; set; }
        public DateTime Datum { get; set; }

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
