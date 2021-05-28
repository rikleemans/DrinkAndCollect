using System.Collections.Generic;
using System.Collections.ObjectModel;
using Dal.Interface;
using Logic.Interface;

namespace Logic.Interface
{
    public interface IReadBeerCollection
    {
        public IReadOnlyCollection<IViewableBeer> GetAllBeerInfo();
        public IReadOnlyCollection<BeernameDTO> GetAllBeer(string name);
        public void AddBeer(int id, int styleid, int catid, string name, string description);
        public void RemoveBeer(int id, int styleid, int catid, string name, string description);
        public void AddCategory(int catID, string category);
        public void RemoveCategory(int catID, string category);
        public void AddStyle(int styleID, string style);
        public void RemoveStyle(int styleID, string style);
    }
}