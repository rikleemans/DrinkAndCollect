using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Dal.Interface
{
    public interface IStyle
    {
        public List<StyleDTO> GetAllStyle();
        public bool AddStyle(StyleDTO styles);
        public bool RemoveStyle(int id);
    }
}
