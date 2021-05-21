using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Dal.Interface;
using Logic;

namespace Logic.Interface
{
    public interface IReadUserCollection
    {
        public bool AddReview(IViewableReview review);
        public bool RemoveReview(int id);
        public bool AddFriend(IViewableUser friend);
        public bool RemoveFriend(int id);
        public void RateReview(int userID, int friendID, string username, string firstname, string lastname);
    }


}
