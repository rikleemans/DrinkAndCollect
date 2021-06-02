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
    public class BeerCollectionDal : IBeerCollection
    {
        public List<BeerDTO> GetAllBeerInfo()
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));

            var output = connection.Query<BeerDTO>("dbo.GetAllBeerInfo").ToList();
            return output;
        }

        public List<BeernameDTO> GetAllBeer(string name)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@name", name);
            var output = connection.Query<BeernameDTO>("dbo.GetAllBeer @name", parameters).ToList();
            return output;

        }

        public bool AddBeer(BeerDTO beerDto)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            var result = connection.Execute("dbo.AddBeer  @id, @catID, @styleID, @name, @description", beerDto);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public bool RemoveBeer(int id)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@id", id);
            var result = connection.Execute("dbo.RemoveBeer @id", parameters);
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

