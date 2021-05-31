using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndCollectV6.Models
{
    public class FriendCollectionViewModel
    {
        public int ReviewID { get; }
        public int FriendID { get; }
        public int BeerID { get; }
        public int Rate { get; }
        public string Taste { get; }
        public string Description { get; }
        public DateTime Datum { get; }

        public FriendCollectionViewModel(int reviewID, int friendID, int beerID, int rate, string taste, string description, DateTime datum)
        {
            ReviewID = reviewID;
            FriendID = friendID;
            BeerID = beerID;
            Rate = rate;
            Taste = taste;
            Description = description;
            Datum = datum;
        }
    }
}
