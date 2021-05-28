using System;
using System.Collections.Generic;
using System.Text;
using Dal.Interface;

namespace DrinkAndCollectV4.Models
{
    public class FriendViewModel
    {
        public int UserID { get; set; }
        public int FriendID { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public FriendViewModel(int userID, int friendID, string username, string firstname, string lastname)
        {
            UserID = userID;
            FriendID = friendID;
            Username = username;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
