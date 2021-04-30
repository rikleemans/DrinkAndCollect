using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
   public class UserDTO
    {
        public string Username { get; }
        public string Password { get; }
        public string Firstname { get; }
        public string Lastname { get; }
        public int Admin { get; }
        public int Friend { get; }

        public UserDTO(string username, string password, string firstname, string lastname, int admin, int friend)
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
