using Dal.Interface;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dal
{
    class BeerCategorieDal
    {
        public void AddCategorie(string categorie)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));

            List<BeerCategorieDTO> cate = new List<BeerCategorieDTO>();

            cate.Add(new BeerCategorieDTO(categorie));

            connection.Execute("dbo.InsertCategorie");

        }
    }
}
