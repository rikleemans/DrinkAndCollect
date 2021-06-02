using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndCollectV6.Models
{
    public class BeerViewModel
    {
        [Required]
        public int ID { get; }
        public int StyleID { get; }
        public int CatID { get; }
        public string Name { get; }
        public string Description { get; }

        public BeerViewModel()
        {

        }
        public BeerViewModel(int id, int styleid, int catid, string name, string description)
        {
            ID = id;
            StyleID = styleid;
            CatID = catid;
            Name = name;
            Description = description;
        }
    }
}
