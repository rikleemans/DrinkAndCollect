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
        public string Categorie { get; }

        #endregion

        public CategoryDTO(string categorie)
        {
            Categorie = categorie;

        }

    }
}
