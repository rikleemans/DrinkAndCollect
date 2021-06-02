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
        private List<BeernameDTO> _beername = new List<BeernameDTO>();
        private readonly List<BeerDTO> _beer = new List<BeerDTO>();
        private readonly List<Style> _style= new List<Style>();
        private readonly List<Category> _categorycollection = new List<Category>();
        private readonly IStyle _dalstyle;
        private readonly ICategory _dalcat;

        public BeerCollection()
        {
            _dal = BeerCollectionFactory.CreateBeerCollectionDal();
            _dalcat = CategoryFactory.CreateCategoryDal();
            _dalstyle = StyleFactory.CreateStyleDal();
        }

        public IReadOnlyCollection<IViewableBeer> GetAllBeerInfo()
        {
            _beerCollection.Clear();
            _dal.GetAllBeerInfo().ForEach(
                dto => _beerCollection.Add(new Beer(dto)));
            return _beerCollection.AsReadOnly();
        }
        public IReadOnlyCollection<IViewableCategory>GetAllCategory()
        {
            _categorycollection.Clear();
            _dalcat.GetAllCategory().ForEach(
                dto => _categorycollection.Add(new Category(dto)));
            return _categorycollection.AsReadOnly();
        }
        public IReadOnlyCollection<IViewableStyle> GetAllStyle()
        {
            _style.Clear();
            _dalstyle.GetAllStyle().ForEach(
                dto => _style.Add(new Style(dto)));
            return _style.AsReadOnly();
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
            //return _dal.AddBeer(beer.ConvertToDto());
        }

        public bool RemoveBeer(int id)
        {
            return _dal.RemoveBeer(id);
            //return _dal.RemoveBeer(id);
        }
        public bool AddCategory(int catID, string name)
        {
            var category = new Category(catID, name);
            _categorycollection.Add(category);
           return _dalcat.AddCategory(category.ConvertToDto());
            //return _dalcat.AddCategory(name);
        }

        public bool RemoveCategory(int id)
        {
           return _dalcat.RemoveCategory(id);
            //return _dalcat.RemoveCategory(id);
        }
        public bool AddStyle(int styleID, string name)
        {
            var styles = new Style(styleID, name);
            _style.Add(styles);
           return _dalstyle.AddStyle(styles.ConvertToDto());
            //return _dalstyle.AddStyle(name);
        }

        public bool RemoveStyle(int id)
        {
           return _dalstyle.RemoveStyle(id);
            //return _dalstyle.RemoveStyle(id);
        }
    }
}
