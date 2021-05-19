using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Dal.Interface;
using Logic;

namespace Logic.Interface
{
    public interface IReadUserCollection
    {
        bool AddReview(IViewableReview review);
        bool RemoveReview(int id);
        bool AddFriend(IViewableUser friend);
        bool RemoveFriend(int id);
        void RateReview(int userID, int friendID, string username, string firstname, string lastname);
    }


}
