using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using MySql.Data.MySqlClient;
using System.Linq;
using Dapper;
using System.Data;
using System.Threading.Tasks;

namespace Dal
{
   public static  class DalAccess
   {
       public static string GetConnectionString(string name)
       {
           return ConfigurationManager.ConnectionStrings[name].ConnectionString;
       }
    }
}
