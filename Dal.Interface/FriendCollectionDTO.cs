using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dal.Interface
{
    public class FriendCollectionDTO
    {
        #region properties
        [Key]
        public int ReviewID { get; }
        public int FriendID { get; }
        public int BeerID { get; }
        public int Rate { get; }
        public string Taste { get; }
        public string Description { get; }
        public DateTime Datum { get; }
        #endregion

        public FriendCollectionDTO()
        {

        }
        public FriendCollectionDTO(int reviewID, int friendID, int beerID, int rate, string taste, string description, DateTime datum)
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
