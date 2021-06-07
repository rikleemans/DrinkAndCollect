using Dal.Factory;
using Dal.Interface;
using System;
using System.Collections.Generic;
using Logic.Interface;

namespace Logic
{
    public class Review : IViewableReview, IReadReview
    {
        #region properties
        public int ReviewID { get; }
        public string UserID { get; }
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
            _dal = ReviewFactory.CreateReviewDal();
        }

        public Review(int reviewID, string userID, int beerID, int rate, string taste, string description, DateTime datum)
        {
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

        public bool UpdateReview(int reviewID, string userID, int beerID, int rate, string taste, string description, DateTime datum)
        {
            try
            {
                var review = new Review(reviewID, userID, beerID, rate, taste, description, datum);
                _review.Add(review);
                return _dal.UpdateReview(review.ConvertToDto());
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }
    }
}