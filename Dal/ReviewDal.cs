using Dal.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace Dal
{
    public class ReviewDal : IReview
    {

        public bool UpdateReview(ReviewDTO review)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            var result = connection.Execute("dbo.UpdateReview @reviewID, @userID, @rate, @taste, @description, @createdOn", review);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}