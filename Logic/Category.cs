using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Dal.Factory;
using Dal.Interface;
using Logic.Interface;

namespace Logic
{
   public class Category : IViewableCategory , IReadCategory
   {
        public int CatID { get; }
        public string Name { get; }

        private readonly ICategory _dalcat;
        private readonly List<Category> _categorycollection = new List<Category>();
        public Category(int catID, string name)
        {
            CatID = catID;
            Name = name;
        }
        public Category()
        {
            _dalcat = CategoryFactory.CreateCategoryDal();
        }

        public Category(CategoryDTO dto)
        {
            CatID = dto.CatID;
            Name = dto.Name;

        }
        public IReadOnlyCollection<IViewableCategory> GetAllCategory()
        {
             _categorycollection.Clear();
             _dalcat.GetAllCategory().ForEach(
             dto => _categorycollection.Add(new Category(dto)));
             return _categorycollection.AsReadOnly();
        }
        public bool AddCategory(int catID, string name)
        {
            var category = new Category(catID, name);
            _categorycollection.Add(category);
            return _dalcat.AddCategory(category.ConvertToDto());
        }

        public bool RemoveCategory(int id)
        {
            return _dalcat.RemoveCategory(id);
        }
        public CategoryDTO ConvertToDto()
        {
            return new CategoryDTO(CatID, Name);
        }
    }
}
