using Dal.Interface;
using Dapper;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Test.TestDal
{
    public class UserCollectionTestDal : IUserCollection
    {

        public bool AddReview(ReviewDTO review)
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

        public bool RemoveReview(int id)
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

        public void RateReview(UserDTO rate)
        {

        }
    }
}
