using System.Collections.Generic;
using System.Collections.ObjectModel;
using Dal.Interface;
using Logic.Interface;

namespace Logic.Interface
{
    public interface IReadBeerCollection
    {
        public IReadOnlyCollection<IViewableCategory> GetAllCategory();
        public IReadOnlyCollection<IViewableStyle> GetAllStyle();
        public IReadOnlyCollection<IViewableBeer> GetAllBeerInfo();
        public IReadOnlyCollection<BeernameDTO> GetAllBeer(string name);
        public bool AddBeer(int id, int styleid, int catid, string name, string description);
        public bool RemoveBeer(int id);
        public bool AddCategory(int catID, string name);
        public bool RemoveCategory(int id);
        public bool AddStyle(int styleID, string name);
        public bool RemoveStyle(int id);
    }
}