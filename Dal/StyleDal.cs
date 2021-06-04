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
    public class StyleDal : IStyle
    {
        public List<StyleDTO> GetAllStyle()
        {
            try
            {
                using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));

             var output = connection.Query<StyleDTO>("dbo.GetAllStyle").ToList();
             return output;
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
        public bool AddStyle(StyleDTO styles)
        {
            try
            {
              using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
              var result = connection.Execute("dbo.AddStyle @styleID, @name", styles);
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
        public bool RemoveStyle(int id)
        {
            try
            {
                using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@styleID", id);
                var result = connection.Execute("dbo.DeleteStyle @styleID", parameters);
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
