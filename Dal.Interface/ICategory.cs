using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Dal.Interface
{
    public interface ICategory
    {
        public bool AddCategory(CategoryDTO categories);
        public bool RemoveCategory(int id);

    }
}
