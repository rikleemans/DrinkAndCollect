using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Dal.Interface;
using Dapper;
using Org.BouncyCastle.Bcpg;

namespace Dal
{
    public class UserCollectionDal : IUserCollection
    {
        public UserCollectionDal()
        {
            
        }

        public void Login()
        {

        }

        public void Register()
        {

        }

        public void AddReview(ReviewDTO review)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));

            connection.Execute("dbo.InsertReview");
        }

        public void RemoveReview(ReviewDTO review)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));

            connection.Execute("dbo.RemoveReview");
        }
        public void AddFriend(UserDTO friends)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));

            connection.Execute("dbo.AddFriend");
        }

        public void RemoveFriend(UserDTO friends)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));

            connection.Execute("dbo.RemoveFriend");
        }

        public void RateReview(UserDTO rate)
        {

        }
    }
}
