using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dal.Interface
{
    public class ReviewDTO
    {
        #region properties

        public int ReviewID { get; }
        public string UserID { get; }
        public int BeerID { get; }
        public int Rate { get; }
        public string Taste { get; }
        public string Description { get; }
        public DateTime Datum { get; }
        #endregion

        public ReviewDTO(int reviewID, string userID, int beerID, int rate, string taste, string description, DateTime datum)
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
