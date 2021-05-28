using Dal.Factory;
using Dal.Interface;
using Dal.Interface.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;
using Logic.Interface;

namespace Logic
{
    public class BeerCollection : IReadBeerCollection
    {

        private readonly IBeerCollection _dal;
        private readonly List<Beer> _beerCollection = new List<Beer>();
        private readonly List<BeernameDTO> _beername = new List<BeernameDTO>();
        private readonly List<BeerDTO> _beer = new List<BeerDTO>();
        private readonly List<StyleDTO> _style= new List<StyleDTO>();
        private readonly List<CategoryDTO> _category = new List<CategoryDTO>();
        private readonly IStyle _dalstyle;
        private readonly ICategory _dalcat;

        public BeerCollection()
        {
            _dal = BeerCollectionFactory.CreateBeerCollectionDal();

        }

        public IReadOnlyCollection<IViewableBeer> GetAllBeerInfo()
        {
            _beerCollection.Clear();
            _dal.GetAllBeerInfo().ForEach(
                dto => _beerCollection.Add(new Beer(dto)));
            return _beerCollection.AsReadOnly();
        }

        public IReadOnlyCollection<BeernameDTO> GetAllBeer(string name)
        {
            _beername.Clear();
            _dal.GetAllBeer(name);
            return _beername.AsReadOnly();
        }

        public void AddBeer(int id, int styleid, int catid, string name, string description)
        {
            var beer = new Beer(id, styleid, catid, name, description);
            _beerCollection.Add(beer);
            _dal.AddBeer(beer.ConvertToDto());
            //return _dal.AddBeer(beer.ConvertToDto());
        }

        public void RemoveBeer(int id, int styleid, int catid, string name, string description)
        {
            var beer = new Beer(id, styleid, catid, name, description);
            _beerCollection.Add(beer);
            _dal.RemoveBeer(beer.ConvertToDto());
            //return _dal.RemoveBeer(id);
        }
        public void AddCategory(int catID, string category)
        {
            var categories = new CategoryDTO(catID, category);
            _category.Add(categories);
            _dalcat.AddCategory(categories.ConvertToDto());
            //return _dalcat.AddCategory(name);
        }

        public void RemoveCategory(int catID, string category)
        {
            var categories = new CategoryDTO(catID, category);
            _category.Add(categories);
            _dalcat.RemoveCategory(categories.ConvertToDto());
            //return _dalcat.RemoveCategory(id);
        }
        public void AddStyle(int styleID, string style)
        {
            var styles = new StyleDTO(styleID, style);
            _style.Add(styles);
            _dalstyle.AddStyle(styles.ConvertToDto());
            //return _dalstyle.AddStyle(name);
        }

        public void RemoveStyle(int styleID, string style)
        {
            var styles = new StyleDTO(styleID, style);
            _style.Add(styles);
            _dalstyle.RemoveStyle(styles.ConvertToDto());
            //return _dalstyle.RemoveStyle(id);
        }
    }
}
