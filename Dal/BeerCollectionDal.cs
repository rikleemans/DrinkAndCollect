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
        public List<BeernameDTO> GetAllBeer(string beername)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@beername", beername);
            
                var output = connection.Query<BeernameDTO>("dbo.GetAllBeers @beername", parameters).ToList();
                return output;
            
        }

        public void AddBeer(string name, string beerdescription, string style)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));
            List<BeerDTO> beers = new List<BeerDTO>();

                beers.Add(new BeerDTO(name, beerdescription, style));

                connection.Execute("dbo.InsertBeer");
        }

        public void RemoveBeer(string name, string beerdescription, string style)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));
            List<BeerDTO> beers = new List<BeerDTO>();

                beers.Remove(new BeerDTO(name, beerdescription, style));

                connection.Execute("dbo.RemoveBeer");
        }
    }
}
