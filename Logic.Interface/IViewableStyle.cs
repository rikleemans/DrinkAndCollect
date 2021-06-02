using System;
using System.Collections.Generic;
using System.Text;
using Dal.Interface;

namespace Logic.Interface
{
    public interface IViewableStyle
    {
        public int StyleID { get; }
        public string Name { get; }

        public StyleDTO ConvertToDto()
        {
            return new StyleDTO(StyleID, Name);
        }
    }
}
