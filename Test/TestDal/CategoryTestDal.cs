using System;
using Dal.Interface;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dal;

namespace Test.TestDal
{
    public class CategoryTestDal : ICategory
    {
        public List<CategoryDTO> GetAllCategory()
        {
            try
            {
                using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                var output = connection.Query<CategoryDTO>("dbo.GetAllCategory").ToList(); 
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
        public bool AddCategory(CategoryDTO category)
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
        public bool RemoveCategory(int id)
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
