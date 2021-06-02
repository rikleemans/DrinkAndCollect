using Dal.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Factory
{
    public static class CategoryFactory
    {
        public static ICategory CreateCategoryDal()
        {
            return new CategoryDal();
        }
    }
}

