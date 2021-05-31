using Dal.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace Dal
{
    public class BeerDal : IBeer
    {
        public bool UpdateBeer(BeerDTO beerDTO)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
           var result =  connection.Execute("dbo.UpdateBeer @id, @styleID, @catID, @name, @description", beerDTO);

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
