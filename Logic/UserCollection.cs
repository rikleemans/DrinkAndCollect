using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dal.Factory;
using Dal.Interface;

namespace Logic
{
    public class UserCollection
    {
        private List<User> user = new List<User>();
        private IUserCollection _dal;

        public UserCollection()
        {
            _dal = UserCollectionFactory.CreateUserCollectionDal();
        }

        //public void Register(string username, string password, string firstname, string lastname, int admin, int friend, bool succes)
        //{
        //    User users = new User(username, password, firstname, lastname, admin, friend, succes);

        //    #region Foreach way
        //    //bool found = false;
        //    //foreach (var raceDiscipline in raceDisciplines)
        //    //{
        //    //    if (raceDiscipline.Name == discipline.Name)
        //    //    {
        //    //        found = true;
        //    //        break;
        //    //    }
        //    //}

        //    //if (!found)
        //    //{
        //    //    raceDisciplines.Add(discipline);
        //    //}
        //    // Instead of foreach, we can use a Linq query:
        //    #endregion Foreach way

        //    if (!user.Exists(uses => uses.Username == uses.Username))
        //    {
        //        user.Add(users);
        //        dal.Register(users.ConvertToDTO()); // Create DTO from Discipline
        //    }
        //}

        //public void RemoveRaceDiscipline(string name)
        //{
        //    User users = user.FirstOrDefault(uses => uses.Username == name);
        //    if (users != null)
        //    {
        //        user.Remove(users);
        //        dal.RemoveUser(users.ConvertToDTO()); // Create DTO from Discipline
        //    }

        //}

        //public IReadOnlyCollection<User> GetAllRaceDisciplines()
        //{
        //    List<UserDTO> users = dal.GetAllUser();
        //    user.Clear();
        //    foreach (UserDTO DTO in users)
        //    {
        //        user.Add(new User(DTO));
        //    }
        //    return user.AsReadOnly(); // Create Discipline From DTO
        //}
    }
}
