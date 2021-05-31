using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndCollectV6.Models
{
    public class StyleViewModel
    {
        public string Style { get; }
        public int StyleID { get; }

        public StyleViewModel(string style, int styleID)
        {
            Style = style;
            StyleID = styleID;
        }
    }
}
