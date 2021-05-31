using Dal.Interface;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dal
{
    public class CategoryDal : ICategory
    {
        public bool AddCategory(CategoryDTO category)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            //DynamicParameters parameters = new DynamicParameters();
            //parameters.Add("name", category);
            var result = connection.Execute("dbo.InsertCategorie @catID, @category", category);
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
            var result = connection.Execute("dbo.DeleteCat @catID", id);
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
