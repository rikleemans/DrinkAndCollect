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
        public bool UpdateBeer(BeerDTO beer)
        {
            try
            {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
           var result =  connection.Execute("dbo.UpdateBeer @id, @styleID, @catID, @name, @description", beer);

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
    }
}
