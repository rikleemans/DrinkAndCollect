using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
    public interface IUserCollection
    {
        bool AddReview(ReviewDTO review);
        bool RemoveReview(int id);
        bool AddFriend(FriendDTO friend);
        bool RemoveFriend(int userID, int friendID);
        void RateReview(UserDTO rate);
    }

}
