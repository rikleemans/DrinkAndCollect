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
        public bool AddBeer(IViewableBeer beer);
        public bool RemoveBeer(int id);
        public bool AddCategory(string name);
        public bool RemoveCategory(int id);
        public bool AddStyle(string name);
        public bool RemoveStyle(int id);
    }
}