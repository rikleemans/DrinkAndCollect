using Dal;
using Dal.Factory;
using Dal.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Logic.Interface;


namespace Logic
{
    public class User : IViewableUser, IReadUser
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
        private readonly List<FriendCollectionDTO> _friendcollection = new List<FriendCollectionDTO>();
        private readonly List<Friend> _friends = new List<Friend>();

        public User(string username, string password, string firstname, string lastname, int admin, int friend)
        {
            Username = username;
            Password = password;
            Firstname = firstname;
            Lastname = lastname;
            Admin = admin;
            Friend = friend;
        }

        public User()
        {
            _dal = UserFactory.CreateUserDal();
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

        public IReadOnlyCollection<IViewableReview> GetAllReviews()
        {
            _review.Clear();
            _dal.GetAllReviews().ForEach(
            dto => _review.Add(new Review(dto)));
            return _review.AsReadOnly();
        }
        public IReadOnlyCollection<IViewableReview> GetAllReviewsByUser(int id)
        {
            _review.Clear();
            _dal.GetAllReviewsByUser(id).ForEach(
            dto => _review.Add(new Review(dto)));
            return _review.AsReadOnly();
        }
        public IReadOnlyCollection<IViewableReview> GetCollection(int id)
        {
            _review.Clear();
            _dal.GetCollection(id).ForEach(
            dto => _review.Add(new Review(dto)));
            return _review.AsReadOnly();
        }
        public IReadOnlyCollection<IViewableFriend> GetAllFriends(string id)
        {
            _friends.Clear();
            _dal.GetAllFriends(id).ForEach(
            dto => _friends.Add(new Friend(dto)));
            return _friends.AsReadOnly();
        }

        public IReadOnlyCollection<IViewableFriendCollection> GetFriendCollection(int id, int friendid)
        {
            _user.Clear();
            _dal.GetFriendCollection(id, friendid).ForEach(
            dto => _friendcollection.Add(dto));
            return (IReadOnlyCollection<IViewableFriendCollection>)_friendcollection.AsReadOnly();
        }

        public bool AddFriend(string userID, string friendID, string username)
        {
            var friend = new FriendDTO(userID, friendID, username);
            _friend.Add(friend);
            return _dal.AddFriend(friend.ConvertToDto());
            //return _dal.AddFriend(friend.ConvertToDto());
        }

        public bool RemoveFriend(string userID, string friendID)
        {
            return _dal.RemoveFriend(userID, friendID);
            //return _dal.RemoveFriend(id);
        }
    }
}