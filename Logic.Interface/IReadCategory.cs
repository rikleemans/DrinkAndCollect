using System.Collections.Generic;
using System.Collections.ObjectModel;
using Dal.Interface;
using Logic.Interface;

namespace Logic.Interface
{
    public interface IReadCategory
    {
        public IReadOnlyCollection<IViewableCategory> GetAllCategory();
        public bool AddCategory(int catID, string name);
        public bool RemoveCategory(int id);

    }
}