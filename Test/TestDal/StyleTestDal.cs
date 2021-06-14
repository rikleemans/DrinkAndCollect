using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dal;
using Dal.Interface;
using Dapper;

namespace Test.TestDal
{
    public class StyleTestDal : IStyle
    {
        public List<StyleDTO> GetAllStyle()
        {
            try
            { 
                using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                var output = connection.Query<StyleDTO>("dbo.GetAllStyle").ToList();
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
        public bool AddStyle(StyleDTO styles)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool RemoveStyle(int id)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
