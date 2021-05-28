using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndCollectServer.Models
{
    public class CategoryViewModel
    {
        public string Categorie { get; }
        public int CatID { get; }

        public CategoryViewModel(string categorie, int catiD)
        {
            Categorie = categorie;
            CatID = catiD;
        }
    }
}
