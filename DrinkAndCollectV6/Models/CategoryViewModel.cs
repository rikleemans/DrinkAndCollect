using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndCollectV6.Models
{
    public class CategoryViewModel
    {
        public int CatID { get; }
        public string Name { get; }

        public CategoryViewModel()
        {

        }
        public CategoryViewModel(int catID, string name)
        {
            CatID = catID;
            Name = name;
        }
    }
}
