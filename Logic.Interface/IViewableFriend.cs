using System;
using System.Collections.Generic;
using System.Text;
using Dal.Interface;

namespace Logic.Interface
{
    public interface IViewableFriend
    {
        public string UserID { get; }
        public string FriendID { get; }
        public string Username { get; }

        public FriendDTO ConvertToDto()
        {
            return new FriendDTO(UserID, FriendID, Username);
        }
    }
}
