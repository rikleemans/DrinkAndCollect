using Logic.Interface;
using System;
using Logic;

namespace Logic.Factory
{
    public static class ReviewFactory
    {
        public static IReadReview CreateReviewLogic()
        {
            return new Review();
        }
    }
}
