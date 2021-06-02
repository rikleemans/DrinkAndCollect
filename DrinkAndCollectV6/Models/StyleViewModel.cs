using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndCollectV6.Models
{
    public class StyleViewModel
    {
        public int StyleID { get; }
        public string Name { get; }

        public StyleViewModel(int styleID, string name)
        {
            StyleID = styleID;
            Name = name;
        }
    }
}
