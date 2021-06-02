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
        public IReadOnlyCollection<IViewableFriend> GetAllFriends(int id);
        public IReadOnlyCollection<IViewableFriendCollection> GetFriendCollection(int id, int friendid);
        public bool AddFriend(int userID, int friendID, string username, string firstname, string lastname);
        public bool RemoveFriend(int userID, int friendID);
    }
}