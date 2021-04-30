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

        public void UpdateReview(int reviewID, int userID, int beerID, int rate, string taste, string description, DateTime datum)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));
            List<ReviewDTO> beers = new List<ReviewDTO>();

                beers.Add(new ReviewDTO(reviewID, userID, beerID, rate, taste, description, datum));

                connection.Execute("dbo.UpdateReview");
        }
    }
}