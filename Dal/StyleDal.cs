using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dal.Interface;
using Dapper;

namespace Dal
{
    public class StyleDal : IStyle
    {
        public bool AddStyle(StyleDTO styles)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            var result = connection.Execute("dbo.InsertStyle @styleID, @style", styles);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public bool RemoveStyle(StyleDTO styles)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            var result = connection.Execute("dbo.DeleteStyle @styleID, @style", styles);
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
