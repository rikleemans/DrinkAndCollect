using System;
using System.Collections.Generic;
using System.Text;
using Dal;
using Dal.Factory;
using Dal.Interface;

namespace Logic
{
    public class User
    {
        private IUser dal;
        public string Username { get; }
        public string Password { get; }
        public string Firstname { get; }
        public string Lastname { get; }
        public int Admin { get; }
        public int Friend { get; }
        public bool Succes { get; }

        private readonly IUser _dal;
        public User()
        {
            _dal = UserFactory.CreateUserDal();
        }

        //public User(UserDTO userDTO)
        //    : this(userDTO.Username, userDTO.Password, userDTO.Firstname,
        //        userDTO.Lastname, userDTO.Admin, userDTO.Friend, userDTO.Succes)
        //{

        //}

        //public UserDTO ConvertToDTO()
        //{
        //    return new UserDTO(Username, Password, Firstname, Lastname, Admin, Friend, Succes);
        //}

        public void Update()
        {
            // Implement the update function
        }
    }
}
