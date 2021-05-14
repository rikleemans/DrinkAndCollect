using Dal.Factory;
using Dal.Interface;
using Dal.Interface.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace Logic
{
    public class BeerCollection
    {

        private readonly IBeerCollection _dal;
        private readonly List<Beer> _beerCollection = new List<Beer>();
        private readonly List<BeernameDTO> _beername = new List<BeernameDTO>();
        private readonly List<BeerDTO> _beer = new List<BeerDTO>();
        private readonly IStyle _dalstyle;
        private readonly ICategory _dalcat;

        public BeerCollection()
        {
            _dal = BeerCollectionFactory.CreateBeerCollectionDal();

        }

        public ReadOnlyCollection<Beer> GetAllBeerInfo()
        {
            _beerCollection.Clear();
            _dal.GetAllBeerInfo().ForEach(
                dto => _beerCollection.Add(new Beer(dto)));
            return _beerCollection.AsReadOnly();
        }

        public ReadOnlyCollection<BeernameDTO> GetAllBeer(string name)
        {
            _beername.Clear();
            _dal.GetAllBeer(name);
            return _beername.AsReadOnly();
        }

        public bool AddBeer(Beer beer)
        {
            return _dal.AddBeer(beer.ConvertToDto());
        }

        public bool RemoveBeer(int id)
        {
            return _dal.RemoveBeer(id);
        }
        public bool AddCategory(string name)
        {
            return _dalcat.AddCategory(name);
        }

        public bool RemoveCategory(int id)
        {
            return _dalcat.RemoveCategory(id);
        }
        public bool AddStyle(string name)
        {
            return _dalstyle.AddStyle(name);
        }

        public bool RemoveStyle(int id)
        {
            return _dalstyle.RemoveStyle(id);
        }
    }
}
