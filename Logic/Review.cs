using Dal.Factory;
using Dal.Interface;

namespace Logic
{
    class Review
    {
        private readonly IReview _dal;

        public Review()
        {
            _dal = ReviewFactory.CreateReviewDal();
        }
    }
}
