using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndCollectV6.Models
{
    public class FriendViewModel
    {
        public string UserID { get; }
        public string FriendID { get; }
        public string Username { get; }

        public FriendViewModel(string userID, string friendID, string username)
        {
            UserID = userID;
            FriendID = friendID;
            Username = username;
        }
    }
}
