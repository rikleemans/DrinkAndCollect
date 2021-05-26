using System;
using System.Collections.Generic;
using System.Text;
using Dal.Interface;

namespace Logic.Interface
{
    public interface IViewableFriend
    {
        public int UserID { get; }
        public int FriendID { get; }
        public string Username { get; }
        public string Firstname { get; }
        public string Lastname { get; }

        public FriendDTO ConvertToDto()
        {
            return new FriendDTO(UserID, FriendID, Username, Firstname, Lastname);
        }
    }
}
