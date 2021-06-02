using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dal.Interface
{
    public class CategoryDTO
    {
        #region properties
        [Key]
        public int CatID { get; }
        public string Name { get; }

        #endregion

        public CategoryDTO()
        {

        }
        public CategoryDTO(int catID, string name)
        {
            CatID = catID;
            Name = name;
        }

        public CategoryDTO ConvertToDto()
        {
            return new CategoryDTO(CatID, Name);
        }
    }
}
