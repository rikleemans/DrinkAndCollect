using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using Dapper;
using Dal.Interface;


namespace Dal
{
   public class BeerDal : IBeer
    {
        public void UpdateBeer(BeerDTO beerDTO)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));

            connection.Execute("dbo.UpdateBeer @name, @beerdescription, @style", beerDTO);
        }
    }
}
