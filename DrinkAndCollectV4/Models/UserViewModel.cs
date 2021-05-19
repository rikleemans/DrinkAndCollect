using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndCollectV4.Models
{
    public class UserViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Admin { get; set; }
        public int Friend { get; set; }

        public UserViewModel(string username, string password, string firstname, string lastname, int admin, int friend)
        {
            Username = username;
            Password = password;
            Firstname = firstname;
            Lastname = lastname;
            Admin = admin;
            Friend = friend;
        }
    }
}
