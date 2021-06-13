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
            try
            {
                 using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));

                 var output = connection.Query<BeerDTO>("dbo.GetAllBeerInfo").ToList();
                 return output;
            }
            catch (SqlException e)
            {
                throw new Exception("Database cannot connect, try again");
            }
            catch (Exception e)
            {
                throw new Exception( "Something went wrong, try again");
            }
        }
        public BeerDTO GetBeerById(int id)
        {
            try{
                  using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                  DynamicParameters parameters = new DynamicParameters();
                  parameters.Add("@id", id);
                  var output = connection.Query<BeerDTO>("dbo.GetAllBeerById @id", parameters);
                  return output.FirstOrDefault();
            }
            catch (SqlException e)
            {
                throw new Exception("Database cannot connect, try again");
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }

        public List<BeernameDTO> GetAllBeer(string name)
        {
            try{
                 using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                 DynamicParameters parameters = new DynamicParameters();
                 parameters.Add("@name", name);
                 var output = connection.Query<BeernameDTO>("dbo.GetAllBeer @name", parameters).ToList();
                 return output;
            }
            catch (SqlException e)
            {
                throw new Exception("Database cannot connect, try again");
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }

        }

        public bool AddBeer(BeerDTO beerDto)
        {
            try
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
            catch (SqlException e)
            {
                throw new Exception("Database cannot connect, try again");
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }

        public bool RemoveBeer(int id)
        {
            try
            {
                 using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                 DynamicParameters parameters = new DynamicParameters();
                 parameters.Add("@id", id);
                 var result = connection.Execute("dbo.RemoveBeer @id", parameters);
                if (result > 0)
                {
                    return true;
                }
                else return false;
            }
            catch (SqlException e)
            {
                throw new Exception("Database cannot connect, try again");
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }
    }
}

