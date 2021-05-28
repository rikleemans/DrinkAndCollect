using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
    public interface IUserCollection
    {
        bool AddReview(ReviewDTO review);
        bool RemoveReview(ReviewDTO review);
        bool AddFriend(FriendDTO friend);
        bool RemoveFriend(FriendDTO friend);
        void RateReview(UserDTO rate);
    }

}
