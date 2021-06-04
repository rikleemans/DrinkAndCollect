using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
    public interface  IUser
    {
        public List<ReviewDTO> GetAllReviews();
        List<ReviewDTO> GetAllReviewsByUser(int id);
        List<FriendDTO> GetAllFriends(string id);
        List<FriendCollectionDTO> GetFriendCollection(int id, int friendid);
        List<ReviewDTO> GetCollection(int id);
        bool AddFriend(FriendDTO friend);
        bool RemoveFriend(string userID, string friendID);

    }
}
