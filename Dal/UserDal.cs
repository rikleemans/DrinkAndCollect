using Dal.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Dal
{
    public class UserDal : IUser

    {
        public UserDal()
        {

        }

        public List<ReviewDTO> GetAllReviews()
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));

            var output = connection.Query<ReviewDTO>("dbo.GetAllReviews").ToList();
            return output;
        }
        public List<ReviewDTO> GetAllReviewsByUser(int id)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@id", id);
            var output = connection.Query<ReviewDTO>("dbo.GetAllReviewsByUser", parameters).ToList();
            return output;
        }
        public List<ReviewDTO> GetCollection(int id)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@id", id);
            var output = connection.Query<ReviewDTO>("dbo.GetCollection", parameters).ToList();
            return output;
        }

        //public void UpdateAccount(UserDTO user)
        //{
        //    using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));

        //    connection.Execute("dbo.UpdateUser @", user);
        //}

        public List<FriendDTO> GetAllFriends(int id)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@id", id);
            var output = connection.Query<FriendDTO>("dbo.GetAllFriends", parameters).ToList();
            return output;

        }

        public List<FriendCollectionDTO> GetFriendCollection(int id, int friendid)
        {
            using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@id", id);
            parameters.Add("@friendid", friendid);
            var output = connection.Query<FriendCollectionDTO>("dbo.GetFriendCollection", parameters).ToList();
            return output;

        }

    }

}
