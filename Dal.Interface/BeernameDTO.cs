using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dal.Interface
{
    public class BeernameDTO
    {
        #region properties
        [Key]
        public string Name { get; }
        #endregion

        public BeernameDTO(string name)
        {
            Name = name;

        }
    }
}

