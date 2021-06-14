using Dal.Factory;
using Dal.Interface;
using Dal.Interface.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using Logic.Interface;

namespace Logic
{
    public class BeerCollection : IReadBeerCollection
    {

        private readonly IBeerCollection _dal;
        private readonly List<Beer> _beerCollection = new List<Beer>();
        private List<BeernameDTO> _beername = new List<BeernameDTO>();
        private readonly IBeer _dalbeer;

        public BeerCollection()
        {
            _dalbeer = BeerFactory.CreateBeerDal();
            _dal = BeerCollectionFactory.CreateBeerCollectionDal();
        }

        public BeerCollection(IBeerCollection beerCollection)
        {
            _dal = beerCollection;

            _dalbeer = BeerFactory.CreateBeerDal();
        }

        public IReadOnlyCollection<IViewableBeer> GetAllBeerInfo()
        {
             _beerCollection.Clear();
            _dal.GetAllBeerInfo().ForEach(
             dto => _beerCollection.Add(new Beer(dto)));
            return _beerCollection.AsReadOnly();
        }

        public IViewableBeer GetBeerById(int id)
        {
            return new Beer(_dal.GetBeerById(id));
        }

        public IReadOnlyCollection<BeernameDTO> GetAllBeer(string name)
        {
            _beername.Clear();
            _beername = _dal.GetAllBeer(name);
            return _beername.AsReadOnly();
        }

        public bool AddBeer(int id, int styleid, int catid, string name, string description)
        {
            var beer = new Beer(id, styleid, catid, name, description);
            _beerCollection.Add(beer);
            return _dal.AddBeer(beer.ConvertToDto());
        }

        public bool RemoveBeer(int id)
        {
            return _dal.RemoveBeer(id);
        }
    }
}
