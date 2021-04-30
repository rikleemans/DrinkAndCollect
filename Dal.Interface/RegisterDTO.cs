using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
    class RegisterDTO
    {
        public string Username { get; }
        public string Password { get; }
        public string Firstname { get; }
        public string Lastname { get; }
        public bool Succes { get; }

        public RegisterDTO(string username, string password, string firstname, string lastname, bool succes)
        {
            Username = username;
            Password = password;
            Firstname = firstname;
            Lastname = lastname;
            Succes = succes;
        }
    }
}
