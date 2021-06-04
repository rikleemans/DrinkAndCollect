using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
    public class FriendDTO
    {
        public string UserID { get; }
        public string FriendID { get; }
        public string Username { get; }

        public FriendDTO()
        {

        }

        public FriendDTO(string userID, string friendID, string username)
        {
            UserID = userID;
            FriendID = friendID;
            Username = username;

        }
        public FriendDTO ConvertToDto()
        {
            return new FriendDTO(UserID, FriendID, Username);
        }
    }
}
