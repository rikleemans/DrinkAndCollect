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

        public IReadOnlyCollection<IViewableBeer> GetAllBeerInfo()
        {
            try
            {
                _beerCollection.Clear();
            _dal.GetAllBeerInfo().ForEach(
                dto => _beerCollection.Add(new Beer(dto)));
            return _beerCollection.AsReadOnly();
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }

        public IViewableBeer GetBeerById(int id)
        {
            try
            {
                return new Beer(_dal.GetBeerById(id));
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }

        public IReadOnlyCollection<BeernameDTO> GetAllBeer(string name)
        {
            try
            {
                _beername.Clear();
                _beername = _dal.GetAllBeer(name);
                return _beername.AsReadOnly();
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }

        public bool AddBeer(int id, int styleid, int catid, string name, string description)
        {
            try
            {
                var beer = new Beer(id, styleid, catid, name, description);
                _beerCollection.Add(beer);
                return _dal.AddBeer(beer.ConvertToDto());
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }

        public bool RemoveBeer(int id)
        {
            try
            {
                return _dal.RemoveBeer(id);
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }
    }
}
