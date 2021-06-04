using System.Collections.Generic;
using System.Collections.ObjectModel;
using Dal.Interface;
using Logic.Interface;

namespace Logic.Interface
{
    public interface IReadStyle
    {

        public IReadOnlyCollection<IViewableStyle> GetAllStyle();
        public bool AddStyle(int styleID, string name);
        public bool RemoveStyle(int id);
    }
}