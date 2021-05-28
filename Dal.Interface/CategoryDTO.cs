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
        public string Category { get; }

        #endregion

        public CategoryDTO(int catiD, string category)
        {
            CatID = catiD;
            Category = category;
        }

        public CategoryDTO ConvertToDto()
        {
            return new CategoryDTO(CatID, Category);
        }
    }
}
