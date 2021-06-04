using System;

namespace Logic.Interface
{
    public interface IReadReview
    {
        public bool UpdateReview(int reviewID, string userID, int beerID, int rate, string taste, string description, DateTime datum);
    }
}