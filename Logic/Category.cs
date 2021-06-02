using System;
using System.Collections.Generic;
using System.Text;
using Dal.Factory;
using Dal.Interface;
using Logic.Interface;

namespace Logic
{
   public class Category : IViewableCategory
   {
        public int CatID { get; }
        public string Name { get; }

        private readonly ICategory _dalcat;

        public Category()
        {

        }
        public Category(int catID, string name)
        {
            _dalcat = CategoryFactory.CreateCategoryDal();
            CatID = catID;
            Name = name;
        }

        public Category(CategoryDTO dto)
        {
            CatID = dto.CatID;
            Name = dto.Name;

        }

        public CategoryDTO ConvertToDto()
        {
            return new CategoryDTO(CatID, Name);
        }
    }
}
