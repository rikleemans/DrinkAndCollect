using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
    public interface IUserCollection
    {
        bool AddReview(ReviewDTO review);
        bool RemoveReview(int id);
        void RateReview(UserDTO rate);
    }

}
