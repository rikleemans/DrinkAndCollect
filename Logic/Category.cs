using System;
using System.Collections.Generic;
using System.Text;
using Dal.Factory;
using Dal.Interface;
using System.Collections.ObjectModel;

namespace Logic
{
    class Category
    {
        private readonly ICategory _dal;
        public bool AddCategory(string category)
        {
            return _dal.AddCategorie(category);
        }
    }
}
