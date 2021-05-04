using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
    public interface IUser
    {
        void UpdateAccount(UserDTO user);
        List<ReviewDTO> GetAllReviews();
        List<FriendDTO> GetAllFriends(int UserID);
        List<FriendCollectionDTO> GetFriendCollection(int UserID);
        List<ReviewDTO> GetCollection();

    }
}
