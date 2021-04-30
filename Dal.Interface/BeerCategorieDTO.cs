using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dal.Interface
{
    public class BeerCategorieDTO
    {
        #region properties
            [Key]
            public string Categorie { get; }

            #endregion

            public BeerCategorieDTO(string categorie)
            {
                Categorie = categorie;

            }
        
    }
}
