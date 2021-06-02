using System;
using System.Collections.Generic;
using System.Text;
using Dal.Factory;
using Dal.Interface;
using Logic.Interface;

namespace Logic
{
   public class Style : IViewableStyle
   {
        public int StyleID { get; }
        public string Name { get; }

       private readonly IStyle _dal;

        public Style(int styleID, string name)
        {
            _dal = StyleFactory.CreateStyleDal();
            StyleID = StyleID;
            Name = Name;
        }

        public Style(StyleDTO dto)
        {
            StyleID = dto.StyleID;
            Name = dto.Name;

        }

        public StyleDTO ConvertToDto()
        {
            return new StyleDTO(StyleID, Name);
        }
    }
}
