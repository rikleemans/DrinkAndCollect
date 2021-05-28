using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dal.Interface
{
   public class StyleDTO
    {
        #region properties
        [Key]
        public int StyleID { get; }
        public string Style { get; }

        #endregion

        public StyleDTO(int styleID, string style)
        {
            StyleID = styleID;
            Style = style;
        }
        public StyleDTO ConvertToDto()
        {
            return new StyleDTO(StyleID, Style);
        }
    }
}
