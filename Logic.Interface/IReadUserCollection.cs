using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Dal.Interface;
using Logic;

namespace Logic.Interface
{
    public interface IReadUserCollection
    {
        public bool AddReview(int reviewID, string userID, int beerID, int rate, string taste, string description, DateTime datum);
        public bool RemoveReview(int id);
        public void RateReview(int userID, int friendID, string username, string firstname, string lastname);
    }


}
