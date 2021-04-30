using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
    class LoginDTO
    {
        public string Username { get; }
        public string Password { get; }
        public bool Succes { get; }

        public LoginDTO(string username, string password, bool succes)
        {
            Username = username;
            Password = password;
            Succes = succes;
        }
    }
}
