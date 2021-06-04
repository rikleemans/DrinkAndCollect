using System.Collections.Generic;
using System.Collections.ObjectModel;
using Dal.Interface;
using Logic.Interface;

namespace Logic.Interface
{
    public interface IReadBeerCollection
    {

        public IReadOnlyCollection<IViewableBeer> GetAllBeerInfo();
        public IViewableBeer GetBeerById(int id);
        public IReadOnlyCollection<BeernameDTO> GetAllBeer(string name);
        public bool AddBeer(int id, int styleid, int catid, string name, string description);
        public bool RemoveBeer(int id);

    }
}