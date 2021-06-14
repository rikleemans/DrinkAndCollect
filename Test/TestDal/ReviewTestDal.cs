using Dal.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dal;


namespace Test.TestDal
{
    public class ReviewTestDal : IReview
    {

        public bool UpdateReview(ReviewDTO review)
        {
            try
            {
                using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                var result = connection.Execute("dbo.UpdateReview @reviewID, @userID, @rate, @taste, @description, @createdOn", review);
                if (result > 0)
                {
                    return true;
                }
                else return false;
            }
            catch (SqlException e)
            {
                throw new Exception("Database cannot connect, try again");
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }
    }
}