using Dal.Interface;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dal
{
    public class CategoryDal : ICategory
    {
        public bool AddCategory(string category)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("name", category);
            var result = connection.Execute("dbo.InsertCategorie @name", parameters);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public bool RemoveCategory(int id)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("id", id);
            var result = connection.Execute("dbo.DeleteCat @id", parameters);
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
