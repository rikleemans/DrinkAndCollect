using System.Collections.Generic;
using System.Collections.ObjectModel;
using Dal.Interface;
using Logic.Interface;

namespace Logic.Interface
{
    public interface IReadBeerCollection
    {
        IReadOnlyCollection<IViewableBeer> GetAllBeerInfo();
        IReadOnlyCollection<BeernameDTO> GetAllBeer(string name);
        bool AddBeer(IViewableBeer beer);
        bool RemoveBeer(int id);
        bool AddCategory(string name);
        bool RemoveCategory(int id);
        bool AddStyle(string name);
        bool RemoveStyle(int id);
    }
}