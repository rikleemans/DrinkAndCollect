using System;

namespace Logic.Interface
{
    public interface IReadReview
    {
        public void UpdateReview(int reviewID, int userID, int beerID, int rate, string taste, string description, DateTime datum);
    }
}