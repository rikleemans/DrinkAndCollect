using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
    public interface IUser
    {
        List<ReviewDTO> GetAllReviews();
        List<ReviewDTO> GetAllReviewsByUser(int id);
        List<FriendDTO> GetAllFriends(int id);
        List<FriendCollectionDTO> GetFriendCollection(int id, int friendid);
        List<ReviewDTO> GetCollection(int id);

    }
}
