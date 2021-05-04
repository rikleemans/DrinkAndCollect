using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dal.Factory;
using Dal.Interface;

namespace Logic
{
    public class UserCollection
    {
        public string Username { get; }
        public string Password { get; }
        public string Firstname { get; }
        public string Lastname { get; }
        public int Admin { get; }
        public int Friend { get; }
        private List<UserCollection> _usercollection = new List<UserCollection>();
        private List<Review> _review = new List<Review>();
        private IUserCollection _dal;

        public UserCollection(string username, string password, string firstname, string lastname, int admin, int friend)
        {
            _dal = UserCollectionFactory.CreateUserCollectionDal();
            Username = username;
            Password = password;
            Firstname = firstname;
            Lastname = lastname;
            Admin = admin;
            Friend = friend;
        }

        public UserCollection(UserDTO dto)
        {
            Username = dto.Username;
            Password = dto.Password;
            Firstname = dto.Firstname;
            Lastname = dto.Lastname;
            Admin = dto.Admin;
            Friend = dto.Friend;
        }
        public UserDTO ConvertToDto()
        {
            return new UserDTO(Username, Password, Firstname, Lastname, Admin, Friend);
        }
        public void AddReview(int reviewID, int userID, int beerID, int rate, string taste, string description, DateTime datum)
        {
            var review = new Review(reviewID, userID, beerID, rate, taste, description, datum);
            _review.Add(review);
            _dal.AddReview(review.ConvertToDto());
        }

        public void RemoveReview(int reviewID, int userID, int beerID, int rate, string taste, string description, DateTime datum)
        {
            var review = new Review(reviewID, userID, beerID, rate, taste, description, datum);
            _review.Add(review);
            _dal.RemoveReview(review.ConvertToDto());
        }
        public void AddFriend(string username, string password, string firstname, string lastname, int admin, int friend)
        {
            var friends = new UserCollection(username, password, firstname, lastname, admin, friend);
            _usercollection.Add(friends);
            _dal.AddFriend(friends.ConvertToDto());
        }

        public void RemoveFriend(string username, string password, string firstname, string lastname, int admin, int friend)
        {
            var friends = new UserCollection(username, password, firstname, lastname, admin, friend);
            _usercollection.Add(friends);
            _dal.RemoveFriend(friends.ConvertToDto());
        }
        public void RateReview(int userID, int friendID, string username, string firstname, string lastname)
        {

        }

    }
}
