using Dal.Interface;
using Dal;

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

