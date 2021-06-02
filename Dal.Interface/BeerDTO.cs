using Dal.Interface.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Text;

namespace Dal.Interface
{
    public class BeerDTO
    {
        #region properties
        public int ID { get; }
        public int StyleID { get; }
        public int CatID { get; }
        public string Name { get; }
        public string Description { get; }

        public BeerDTO()
        {

        }

        public BeerDTO(int id)
        {
            ID = id;
        }
        #endregion
        public BeerDTO(int id, int styleid, int catid, string name, string description)
        {
            ID = id;
            StyleID = styleid;
            CatID = catid;
            Name = name;
            Description = description;

        }
        public BeerDTO ConvertToDto()
        {
            return new BeerDTO(ID, StyleID, CatID, Name, Description);
        }
    }
}