using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dal.Interface;


namespace Dal
{
   public class ReviewDal : IReview
    {

        public void UpdateReview(ReviewDTO review)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));

            connection.Execute("dbo.UpdateReview");
        }
    }
}