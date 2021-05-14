using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Dal.Interface
{
    public interface IStyle
    {
        public bool AddStyle(string category);
        public bool RemoveStyle(int id);
    }
}
