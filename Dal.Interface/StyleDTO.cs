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
        public string Name { get; }

        #endregion

        public StyleDTO()
        {

        }
        public StyleDTO(int styleID, string name)
        {
            StyleID = styleID;
            Name = name;
        }
        public StyleDTO ConvertToDto()
        {
            return new StyleDTO(StyleID, Name);
        }
    }
}
