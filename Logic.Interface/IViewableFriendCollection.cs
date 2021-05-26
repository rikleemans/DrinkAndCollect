using Dal.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interface
{
    public interface IViewableFriendCollection
    {
        public int ReviewID { get; }
        public int FriendID { get; }
        public int BeerID { get; }
        public int Rate { get; }
        public string Taste { get; }
        public string Description { get; }
        public DateTime Datum { get; }

        public FriendCollectionDTO ConvertToDto()
        {
            return new FriendCollectionDTO(ReviewID, FriendID, BeerID, Rate, Taste, Description, Datum);
        }
    }
}
