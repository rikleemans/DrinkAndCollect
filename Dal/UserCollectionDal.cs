using Dal.Interface;
using Dapper;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Dal
{
    public class UserCollectionDal : IUserCollection
    {
        public UserCollectionDal()
        {

        }

        public bool AddReview(ReviewDTO review)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            var result = connection.Execute("dbo.InsertReview @reviewID, @userID, @rate, @taste, @description, @createdOn", review);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public bool RemoveReview(int id)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            var result = connection.Execute("dbo.RemoveReview @reviewID", id);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public void RateReview(UserDTO rate)
        {

        }
    }
}
