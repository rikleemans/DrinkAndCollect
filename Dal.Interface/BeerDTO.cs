using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Text;
using Dal.Interface.Enums;

namespace Dal.Interface
{
    public class BeerDTO
    {
        #region properties
        [Key]
        public string Name { get;}
        public string BeerDescription { get; }

        public Style.style Style { get; }
    
        #endregion

        public BeerDTO(string name, string beerdescription, string style)
        {
            Name = name;
            BeerDescription = beerdescription;
            Style = style;

        }
    }
}