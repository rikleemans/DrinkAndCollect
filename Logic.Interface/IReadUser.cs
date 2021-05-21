using System.Collections.Generic;
using Dal.Interface;
using Logic.Interface;

namespace Logic.Interface
{
    public interface IReadUser
    {
        public IReadOnlyCollection<IViewableReview> GetAllReviews();
        public IReadOnlyCollection<IViewableReview> GetAllReviewsByUser(int id);
        public IReadOnlyCollection<IViewableReview> GetCollection(int id);
        public IReadOnlyCollection<FriendDTO> GetAllFriends(int id);
        public IReadOnlyCollection<FriendCollectionDTO> GetFriendCollection(int id, int friendid);
    }
}