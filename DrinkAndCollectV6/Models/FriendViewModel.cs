using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndCollectV6.Models
{
    public class FriendViewModel
    {
        public int UserID { get; }
        public int FriendID { get; }
        public string Username { get; }
        public string Firstname { get; }
        public string Lastname { get; }

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
