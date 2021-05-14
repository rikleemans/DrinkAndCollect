using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
    public class FriendDTO
    {
        public int UserID { get; }
        public int FriendID { get; }
        public string Username { get; }
        public string Firstname { get; }
        public string Lastname { get; }

        public FriendDTO()
        {

        }

        public FriendDTO(int userID, int friendID, string username, string firstname, string lastname)
        {
            UserID = userID;
            FriendID = friendID;
            Username = username;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
