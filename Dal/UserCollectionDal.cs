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

        public void AddReview(int reviewID, int userID, int beerID, int rate, string taste, string description, DateTime datum)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));
            List<ReviewDTO> review = new List<ReviewDTO>();

                review.Add(new ReviewDTO(reviewID, userID, beerID, rate, taste, description, datum));

                connection.Execute("dbo.InsertReview");
        }

        public void RemoveReview(int reviewID, int userID, int beerID, int rate, string taste, string description, DateTime datum)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));
            List<ReviewDTO> review = new List<ReviewDTO>();

                review.Remove(new ReviewDTO(reviewID, userID, beerID, rate, taste, description, datum));

                connection.Execute("dbo.RemoveReview");
        }
        public void AddFriend(int userID, int friendID, string username, string firstname, string lastname)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));

            List<FriendDTO> friend = new List<FriendDTO>();

                friend.Add(new FriendDTO(userID, friendID, username, firstname, lastname));

                connection.Execute("dbo.AddFriend");
        }

        public void RemoveFriend(int userID, int friendID, string username, string firstname, string lastname)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));
            List<FriendDTO> friend = new List<FriendDTO>();

                friend.Remove(new FriendDTO(userID, friendID, username, firstname, lastname));

                connection.Execute("dbo.RemoveFriend");
        }
    }
}
