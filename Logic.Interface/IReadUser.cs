using System.Collections.Generic;
using Dal.Interface;
using Logic.Interface;

namespace Logic.Interface
{
    public interface IReadUser
    {
        public IReadOnlyCollection<IViewableReview> GetAllReviews();
        public IReadOnlyCollection<IViewableReview> GetAllReviewsByUser(string id);
        public IReadOnlyCollection<IViewableReview> GetCollection(string id);
        public IReadOnlyCollection<IViewableFriend> GetAllFriends(string id);
        public IReadOnlyCollection<IViewableFriendCollection> GetFriendCollection(int id, int friendid);
        public bool AddFriend(string userID, string friendID, string username);
        public bool RemoveFriend(string userID, string friendID);
    }
}