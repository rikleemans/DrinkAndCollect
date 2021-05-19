using System.Collections.Generic;
using Dal.Interface;
using Logic.Interface;

namespace Logic.Interface
{
    public interface IReadUser
    {
        IReadOnlyCollection<IViewableReview> GetAllReviews();
        IReadOnlyCollection<IViewableReview> GetAllReviewsByUser(int id);
        IReadOnlyCollection<IViewableReview> GetCollection(int id);
        IReadOnlyCollection<FriendDTO> GetAllFriends(int id);
        IReadOnlyCollection<FriendCollectionDTO> GetFriendCollection(int id, int friendid);
    }
}