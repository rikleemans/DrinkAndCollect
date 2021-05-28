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
        private readonly List<User> _usercollection = new List<User>();
        private List<Review> _review = new List<Review>();
        private List<FriendDTO> _friend = new List<FriendDTO>();
        private IUserCollection _dal;

        public UserCollection()
        {
            _dal = UserCollectionFactory.CreateUserCollectionDal();
        }

        public void AddReview(int reviewID, int userID, int beerID, int rate, string taste, string description, DateTime datum)
        {
            var review = new Review(reviewID, userID, beerID, rate, taste, description, datum);
                _review.Add(review);
                _dal.AddReview(review.ConvertToDto());
                //return _dal.AddReview(review.ConvertToDto());
        }
        // alleen id meegeven
        public void RemoveReview(int reviewID, int userID, int beerID, int rate, string taste, string description, DateTime datum)
        {
            var review = new Review(reviewID, userID, beerID, rate, taste, description, datum);
            _review.Add(review);
            _dal.RemoveReview(review.ConvertToDto());
            //return _dal.RemoveReview(id);
        }
        public void AddFriend(int userID, int friendID, string username, string firstname, string lastname)
        {
            var friend = new FriendDTO(userID, friendID, username, firstname, lastname);
            _friend.Add(friend);
            _dal.AddFriend(friend.ConvertToDto());
            //return _dal.AddFriend(friend.ConvertToDto());
        }

        public void RemoveFriend(int userID, int friendID, string username, string firstname, string lastname)
        {
            var friend = new FriendDTO(userID, friendID, username, firstname, lastname);
            _friend.Add(friend);
            _dal.RemoveFriend(friend.ConvertToDto());
            //return _dal.RemoveFriend(id);
        }
        public void RateReview(int userID, int friendID, string username, string firstname, string lastname)
        {

        }


    }
}
