using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dal;
using Dal.Factory;
using Dal.Interface;
using Dapper;

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

        public void UpdateAccount(string username, string password, string firstname, string lastname, int admin, int friend)
        {

            var user = new User(username, password, firstname, lastname, admin, friend);
            _user.Add(user);
            _dal.UpdateAccount(user.ConvertToDto());
        }
        public List<ReviewDTO> GetAllReviews()
        {
            return _dal.GetAllReviews();
        }
        public List<ReviewDTO> GetCollection()
        {
            return _dal.GetCollection();
        }
        public List<FriendDTO> GetAllFriends(int UserID)
        {
            return _dal.GetAllFriends(UserID);
        }

        public List<FriendCollectionDTO> GetFriendCollection(int UserID)
        {
            return _dal.GetFriendCollection(UserID);
        }
    }
}