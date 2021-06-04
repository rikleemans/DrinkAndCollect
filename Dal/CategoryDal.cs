using System;
using Dal.Interface;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Dal
{
    public class CategoryDal : ICategory
    {
        public List<CategoryDTO> GetAllCategory()
        {
            try
            {
                using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                var output = connection.Query<CategoryDTO>("dbo.GetAllCategory").ToList(); 
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
        public bool AddCategory(CategoryDTO category)
        {
            try
            {
                using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                var result = connection.Execute("dbo.AddCategory @catID, @name", category);
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
        public bool RemoveCategory(int id)
        {
            try
            {
                using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@catID", id);
                var result = connection.Execute("dbo.DeleteCat @catID", parameters);
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
