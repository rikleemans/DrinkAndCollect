using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dal.Interface;
using Dapper;
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
        using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));

        var output = connection.Query<ReviewDTO>("dbo.GetAllReviews").ToList();
        return output;
    }
    public List<ReviewDTO> GetCollection()
    {
        using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));

        var output = connection.Query<ReviewDTO>("dbo.GetCollection").ToList();
        return output;
    }

        public void UpdateAccount(UserDTO user)
    {
        using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));

        connection.Execute("dbo.UpdateUser");
    }

    public List<FriendDTO> GetAllFriends(int UserID)
    {
        using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@UserID", UserID);
            var output = connection.Query<FriendDTO>("dbo.GetAllReviews", parameters).ToList();
        return output;

    }

    public List<FriendCollectionDTO> GetFriendCollection(int UserID)
    {
        using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@UserID", UserID);
            var output = connection.Query<FriendCollectionDTO>("dbo.GetAllReviews", parameters).ToList();
        return output;

    }

    }

}
