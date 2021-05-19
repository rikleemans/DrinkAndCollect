using System;
using System.Collections.Generic;
using System.Text;
using Dal.Interface;

namespace Logic.Interface
{
    public interface IViewableUser
    {
        string Username { get; }
        string Password { get; }
        string Firstname { get; }
        string Lastname { get; }
        int Admin { get; }
         int Friend { get; }

         public UserDTO ConvertToDto()
         {
             return new UserDTO(Username, Password, Firstname, Lastname, Admin, Friend);
         }
    }
}
