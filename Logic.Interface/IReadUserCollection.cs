using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Dal.Interface;
using Logic;

namespace Logic.Interface
{
    public interface IReadUserCollection
    {
        public void AddReview(int reviewID, int userID, int beerID, int rate, string taste, string description, DateTime datum);
        public void RemoveReview(int reviewID, int userID, int beerID, int rate, string taste, string description, DateTime datum);
        public void AddFriend(int userID, int friendID, string username, string firstname, string lastname);
        public void RemoveFriend(int userID, int friendID, string username, string firstname, string lastname);
        public void RateReview(int userID, int friendID, string username, string firstname, string lastname);
    }


}
