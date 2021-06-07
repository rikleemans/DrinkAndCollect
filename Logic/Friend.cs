using System;
using System.Collections.Generic;
using System.Text;
using Dal.Factory;
using Dal.Interface;
using Logic.Interface;

namespace Logic
{
   public class Friend : IViewableFriend
   {
       public string UserID { get; }
       public string FriendID { get; }
       public string Username { get; }

        private readonly IUser _dal;

        public Friend()
        {
            _dal = UserFactory.CreateUserDal();
        }
        public Friend(string userID, string friendID, string username)
        {
            UserID = userID;
            FriendID = friendID;
            Username = username;
        }

        public Friend(FriendDTO dto)
        {
            UserID = dto.UserID;
            FriendID = dto.FriendID;
            Username = dto.Username;

        }

        public FriendDTO ConvertToDto()
        {
            return new FriendDTO(UserID, FriendID, Username);
        }
    }
}
