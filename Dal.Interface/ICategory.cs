using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Dal.Interface
{
    public interface ICategory
    {
        public List<CategoryDTO> GetAllCategory();
       bool AddCategory(CategoryDTO category);
        public bool RemoveCategory(int id);

    }
}
