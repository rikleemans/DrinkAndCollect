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
        public void UpdateBeer(string name, string beerdescription, string style)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));
            List<BeerDTO> beers = new List<BeerDTO>();

                beers.Add(new BeerDTO(name, beerdescription, style));

                connection.Execute("dbo.UpdateBeer");
        }
    }
}
