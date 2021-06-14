using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dal.Interface;
using Dapper;

namespace Test.TestDal
{
    public class BeerDalTest : IBeer
    {
        public bool UpdateBeer(BeerDTO beer)
        {
            try
            {
                return true;
            }
            catch
            {
                return  false;
            }

        }
    }
}
