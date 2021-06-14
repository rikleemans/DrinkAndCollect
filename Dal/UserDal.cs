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

        public List<ReviewDTO> GetAllReviews()
        {
            try
            {
                using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                var output = connection.Query<ReviewDTO>("dbo.GetAllReviews").ToList();
                return output;
            }
            catch (SqlException e)
            {
                throw new Exception("Database cannot connect, try again");
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }
        public List<ReviewDTO> GetAllReviewsByUser(string id)
        {
            try
            {
                 using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                 DynamicParameters parameters = new DynamicParameters();
                 parameters.Add("@id", id);
                 var output = connection.Query<ReviewDTO>("dbo.GetAllReviewsByUser @id" , parameters).ToList();
                 return output;
            }
            catch (SqlException e)
            {
                throw new Exception("Database cannot connect, try again");
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }
        public List<ReviewDTO> GetCollection(string id)
        {
            try
            {
                using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@id", id);
                var output = connection.Query<ReviewDTO>("dbo.GetCollection", parameters).ToList();
                return output;
            }
            catch (SqlException e)
            {
                throw new Exception("Database cannot connect, try again");
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }

        public List<FriendDTO> GetAllFriends(string id)
        {
            try{
                using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@username", id);
                var output = connection.Query<FriendDTO>("dbo.GetAllFriends @username", parameters).ToList();
                return output;
            }
            catch (SqlException e)
            {
                throw new Exception("Database cannot connect, try again");
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }

        }

        public List<FriendCollectionDTO> GetFriendCollection(int id, int friendid)
        {
            try
            {
                using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@id", id);
                parameters.Add("@friendid", friendid);
                var output = connection.Query<FriendCollectionDTO>("dbo.GetFriendCollection", parameters).ToList();
                return output;
            }
            catch (SqlException e)
            {
                throw new Exception("Database cannot connect, try again");
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }

        }

        public bool AddFriend(FriendDTO friends)
        {
            try
            {
                using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                var result = connection.Execute("dbo.AddFriend @userID, @friendID, @username, @firstname, @lastname", friends);
                if (result > 0)
                {
                    return true;
                }
                else return false;
            }
            catch (SqlException e)
            {
                throw new Exception("Database cannot connect, try again");
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }

        public bool RemoveFriend(string userID, string friendID)
        {
            try
            {
                using IDbConnection connection = new SqlConnection(DalAccess.GetConnectionString("DefaultConnection"));
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@userID", userID);
                parameters.Add("@friendID", friendID);
                var result = connection.Execute("dbo.RemoveFriend @userID, @friendID, @username, @firstname, @lastname", parameters);
                if (result > 0)
                {
                    return true;
                }
                else return false;
            }
            catch (SqlException e)
            {
                throw new Exception("Database cannot connect, try again");
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }

    }

}
