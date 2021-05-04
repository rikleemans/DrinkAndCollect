using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
    public interface IUserCollection
    {
        void AddReview(ReviewDTO review);
        void RemoveReview(ReviewDTO review);
        void AddFriend(UserDTO friends);
        void RemoveFriend(UserDTO friends);
        void RateReview(UserDTO rate);
    }
}
