using System;
using System.Collections.Generic;
using System.Text;
using Dal.Factory;
using Dal.Interface;
using Logic.Interface;

namespace Logic
{
   public class Style : IViewableStyle , IReadStyle
   {
        public int StyleID { get; }
        public string Name { get; }

       private readonly IStyle _dalstyle;
       private readonly List<Style> _style = new List<Style>();
        public Style(int styleID, string name)
        {
            _dalstyle = StyleFactory.CreateStyleDal();
            StyleID = styleID;
            Name = name;
        }

        public Style(StyleDTO dto)
        {
            StyleID = dto.StyleID;
            Name = dto.Name;

        }

        public Style()
        {
            _dalstyle = StyleFactory.CreateStyleDal();
        }
        public IReadOnlyCollection<IViewableStyle> GetAllStyle()
        {
            _style.Clear();
            _dalstyle.GetAllStyle().ForEach(
                dto => _style.Add(new Style(dto)));
            return _style.AsReadOnly();
        }
        public bool AddStyle(int styleID, string name)
        {
            var styles = new Style(styleID, name);
            _style.Add(styles);
            return _dalstyle.AddStyle(styles.ConvertToDto());
            //return _dalstyle.AddStyle(name);
        }

        public bool RemoveStyle(int id)
        {
            return _dalstyle.RemoveStyle(id);
            //return _dalstyle.RemoveStyle(id);
        }
        public StyleDTO ConvertToDto()
        {
            return new StyleDTO(StyleID, Name);
        }
    }
}
