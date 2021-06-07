using Dal.Factory;
using Dal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic.Interface;

namespace Logic
{
    public class UserCollection : IReadUserCollection
    {
        private List<Review> _review = new List<Review>();
        private IUserCollection _dal;

        public UserCollection()
        {
            _dal = UserCollectionFactory.CreateUserCollectionDal();
        }

        public bool AddReview(int reviewID, string userID, int beerID, int rate, string taste, string description, DateTime datum)
        {
            try
            {
                var review = new Review(reviewID, userID, beerID, rate, taste, description, datum);
                _review.Add(review);
                return _dal.AddReview(review.ConvertToDto());
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }

        public bool RemoveReview(int id)
        {
            try
            {
                return _dal.RemoveReview(id);
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }
        public void RateReview(int userID, int friendID, string username, string firstname, string lastname)
        {

        }
    }
}
