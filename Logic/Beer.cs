using Dal.Factory;
using Dal.Interface;
using Dal.Interface.Enums;
using Org.BouncyCastle.Asn1.X509;
using System.Collections.Generic;
using System.Dynamic;
using Logic.Interface;

namespace Logic
{
    public class Beer : IViewableBeer, IReadBeer
    {
        #region properties
        public int ID { get; }
        public int StyleID { get; }
        public int CatID { get; }
        public string Name { get; }
        public string Description { get; }

        #endregion

        private readonly IBeer _dal;
        private readonly List<Beer> _beer = new List<Beer>();


        public Beer(int id, int styleid, int catid, string name, string description)
        {
            _dal = BeerFactory.CreateBeerDal();
            ID = id;
            StyleID = styleid;
            CatID = catid;
            Name = name;
            Description = description;
        }
        public Beer()
        {

        }
        public Beer(int id)
        {
            _dal = BeerFactory.CreateBeerDal();
            ID = id;
        }

        public Beer(BeerDTO dto)
        {
            ID = dto.ID;
            StyleID = dto.StyleID;
            CatID = dto.CatID;
            Name = dto.Name;
            Description = dto.Description;
        }

        public bool UpdateBeer(int id, int styleid, int catid, string name, string description)
        {
            var beer = new Beer(id, styleid, catid, name, description);
            _beer.Add(beer);
            return _dal.UpdateBeer(beer.ConvertToDto());
        }

        public BeerDTO ConvertToDto()
        {
            return new BeerDTO(ID, StyleID, CatID, Name, Description);
        }
    }
}

