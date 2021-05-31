using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
    public interface IReview
    {
        public bool UpdateReview(ReviewDTO review);
    }
}
