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
            StyleID = styleID;
            Name = name;
        }
        public Style()
        {
            _dalstyle = StyleFactory.CreateStyleDal();
        }
        public Style(StyleDTO dto)
        {
            StyleID = dto.StyleID;
            Name = dto.Name;

        }
        public IReadOnlyCollection<IViewableStyle> GetAllStyle()
        {
            try
            {
                _style.Clear();
                _dalstyle.GetAllStyle().ForEach(
                dto => _style.Add(new Style(dto)));
            return _style.AsReadOnly();
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }
        public bool AddStyle(int styleID, string name)
        {
            try
            {
                var styles = new Style(styleID, name);
                _style.Add(styles);
                return _dalstyle.AddStyle(styles.ConvertToDto());
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }

        public bool RemoveStyle(int id)
        {
            try
            {
                return _dalstyle.RemoveStyle(id);
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong, try again");
            }
        }
        public StyleDTO ConvertToDto()
        {
            return new StyleDTO(StyleID, Name);
        }
    }
}
