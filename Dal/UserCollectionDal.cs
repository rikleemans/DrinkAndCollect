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

        public bool AddReview(ReviewDTO review)
        {
            try
            {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            var result = connection.Execute("dbo.AddReview @reviewID, @userID, @beerID, @rate, @taste, @description, @datum", review);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database cannot connect, try again");
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong, try again");
            }
        }

        public bool RemoveReview(int id)
        {
            try
            {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@reviewID", id);
            var result = connection.Execute("dbo.DeleteReview @reviewID", parameters);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database cannot connect, try again");
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong, try again");
            }
        }

        public void RateReview(UserDTO rate)
        {

        }
    }
}
