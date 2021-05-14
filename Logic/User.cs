using Dal;
using Dal.Factory;
using Dal.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Logic
{
    public class User
    {
        public string Username { get; }
        public string Password { get; }
        public string Firstname { get; }
        public string Lastname { get; }
        public int Admin { get; }
        public int Friend { get; }

        private readonly IUser _dal;
        private readonly List<User> _user = new List<User>();
        private readonly List<Review> _review = new List<Review>();
        private readonly List<FriendDTO> _friend = new List<FriendDTO>();
        private readonly List<FriendCollectionDTO> _friendc = new List<FriendCollectionDTO>();
        public User(string username, string password, string firstname, string lastname, int admin, int friend)
        {
            _dal = UserFactory.CreateUserDal();
            Username = username;
            Password = password;
            Firstname = firstname;
            Lastname = lastname;
            Admin = admin;
            Friend = friend;
        }

        public User(UserDTO dto)
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
        //public void UpdateAccount(User user)
        //{
        //    _user.Add(user);
        //    _dal.UpdateAccount(user.ConvertToDto());
        //}
        public ReadOnlyCollection<Review> GetAllReviews()
        {
            _review.Clear();
            _dal.GetAllReviews().ForEach(
                dto => _review.Add(new Review(dto)));
            return _review.AsReadOnly();
        }
        public ReadOnlyCollection<Review> GetAllReviewsByUser(int id)
        {
            _review.Clear();
            _dal.GetAllReviewsByUser(id).ForEach(
                dto => _review.Add(new Review(dto)));
            return _review.AsReadOnly();
        }
        public ReadOnlyCollection<Review> GetCollection(int id)
        {
            _review.Clear();
            _dal.GetCollection(id).ForEach(
                dto => _review.Add(new Review(dto)));
            return _review.AsReadOnly();
        }
        public ReadOnlyCollection<FriendDTO> GetAllFriends(int id)
        {
            _user.Clear();
            _dal.GetAllFriends(id).ForEach(
                dto => _friend.Add(dto));
            return _friend.AsReadOnly();
        }

        public ReadOnlyCollection<FriendCollectionDTO> GetFriendCollection(int id, int friendid)
        {
            _user.Clear();
            _dal.GetFriendCollection(id, friendid).ForEach(
                dto => _friendc.Add(dto));
            return _friendc.AsReadOnly();
        }
    }
}