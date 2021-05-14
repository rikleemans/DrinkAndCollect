using Dal;
using Dal.Interface;

namespace Dal.Factory
{
    public static class ReviewFactory
    {
        public static IReview CreateReviewDal()
        {
            return new ReviewDal();
        }
    }
}

