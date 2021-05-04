using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dal.Interface;
using Dapper;

namespace Dal
{
    public class BeerCollectionDal : IBeerCollection
    {
        public List<BeerDTO> GetAllBeerInfo()
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));
            
                var output = connection.Query<BeerDTO>("dbo.GetAllBeerInfo").ToList();
                return output;
            
        }
        public List<BeernameDTO> GetAllBeer(string name)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@name", name);
            
                var output = connection.Query<BeernameDTO>("dbo.GetAllBeers @beername", parameters).ToList();
                return output;
            
        }

        public void AddBeer(BeerDTO beerDto)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));

            connection.Execute("dbo.InsertBeer");
        }

        public void RemoveBeer(BeerDTO beerDto)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));

            connection.Execute("dbo.RemoveBeer");
        }
    }
}
