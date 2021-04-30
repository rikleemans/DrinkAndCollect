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

    public List<ReviewDTO> GetAllReviews(int reviewID, int userID, int beerID, int rate, string taste,
        string description, DateTime datum)
    {
        using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));

        var output = connection.Query<ReviewDTO>("dbo.GetAllReviews").ToList();
        return output;

    }

    public void UpdateAccount(string username, string password, string firstname, string lastname, int admin,
        int friend)
    {
        using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));
        List<UserDTO> user = new List<UserDTO>();

        user.Add(new UserDTO(username, password, firstname, lastname, admin, friend));

        connection.Execute("dbo.UpdateUser");
    }

    public List<FriendDTO> GetAllFriends(int userID, int friendID, string username, string firstname, string lastname)
    {
        using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));

        var output = connection.Query<FriendDTO>("dbo.GetAllReviews").ToList();
        return output;

    }

    public List<FriendCollectionDTO> GetFriendCollection(int reviewID, int friendID, int beerID, int rate, string taste,
        string description, DateTime datum)
    {
        using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DrinkAndCollect"));

        var output = connection.Query<FriendCollectionDTO>("dbo.GetAllReviews").ToList();
        return output;

    }

    }

}
