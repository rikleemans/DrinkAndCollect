using System;
using System.Collections.Generic;
using System.Text;
using Dal.Interface;

namespace Logic.Interface
{
    public interface IViewableBeer
    {
        public int ID { get; }
        public int StyleID { get; }
        public int CatID { get; }
        public string Name { get; }
        public string Description { get; }

        public BeerDTO ConvertToDto()
        {
            return new BeerDTO(ID, StyleID, CatID, Name, Description);
        }
    }
}
