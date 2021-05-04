using System;
using System.Collections.Generic;
using System.Text;
using Dal.Factory;
using Dal.Interface;
using Dal.Interface.Enums;

namespace Logic
{
    public class BeerCollection
    {
        public string Name { get; }
        public string BeerDescription { get; }

        public Style.style Style { get; }
        private readonly IBeerCollection _dal;
        private readonly List<BeerCollection> _beerCollection = new List<BeerCollection>();

        public BeerCollection(string name, string beerdescription, string style)
        {
            _dal = BeerCollectionFactory.CreateBeerCollectionDal();
            Name = name;
            BeerDescription = beerdescription;
            Style = Style.style;
        }
        public BeerCollection(BeerDTO dto)
        {
            Name = dto.Name;
            BeerDescription = dto.BeerDescription;
            Style = dto.style;
        }
        public BeerDTO ConvertToDto()
        {
            return new BeerDTO(Name, BeerDescription, Style);
        }

        public List<BeerDTO> GetAllBeerInfo()
        {
            return _dal.GetAllBeerInfo();
        }

        public List<BeernameDTO> GetAllBeer(string name)
        {
            return _dal.GetAllBeer(name);
        }
        public void AddBeer(string name, string beerdescription, string style)
        {
            var beers = new BeerCollection(name, beerdescription, style);
            _beerCollection.Add(beers);
            _dal.AddBeer(beers.ConvertToDto());
        }

        public void RemoveBeer(string name, string beerdescription, string style)
        {
            var beers = new BeerCollection(name, beerdescription, style);
            _beerCollection.Add(beers);
            _dal.RemoveBeer(beers.ConvertToDto());
        }
    }
}
