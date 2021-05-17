using Dal.Factory;
using Dal.Interface;
using System;
using System.Collections.Generic;

namespace Logic
{
    public class Review
    {
        #region properties
        public int ReviewID { get; }
        public int UserID { get; }
        public int BeerID { get; }
        public int Rate { get; }
        public string Taste { get; }
        public string Description { get; }
        public DateTime Datum { get; }
        #endregion
        private readonly IReview _dal;
        private readonly List<Review> _review = new List<Review>();

        public Review()
        {

        }

        public Review(int reviewID, int userID, int beerID, int rate, string taste, string description, DateTime datum)
        {
            _dal = ReviewFactory.CreateReviewDal();
            ReviewID = reviewID;
            UserID = userID;
            BeerID = beerID;
            Rate = rate;
            Taste = taste;
            Description = description;
            Datum = datum;
        }

        public Review(ReviewDTO dto)
        {
            ReviewID = dto.ReviewID;
            UserID = dto.UserID;
            BeerID = dto.BeerID;
            Rate = dto.Rate;
            Taste = dto.Taste;
            Description = dto.Description;
            Datum = dto.Datum;
        }
        public ReviewDTO ConvertToDto()
        {
            return new ReviewDTO(ReviewID, UserID, BeerID, Rate, Taste, Description, Datum);
        }
        //public class CallingClass{
        //    private List<Review> reviewlijst = new List<Review>();
        //    public List<Review> GetList()
        //    {
        //        return reviewlijst;
        //    }
        //}
        public void UpdateReview(Review review)
        {
            _review.Add(review);
            _dal.UpdateReview(review.ConvertToDto());
        }
    }
}
