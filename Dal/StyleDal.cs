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
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));

            var output = connection.Query<StyleDTO>("dbo.GetAllStyle").ToList();
            return output;
        }
        public bool AddStyle(StyleDTO styles)
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
        public bool RemoveStyle(int id)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            var result = connection.Execute("dbo.DeleteStyle @styleID", id);
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
