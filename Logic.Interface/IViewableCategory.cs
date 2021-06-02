using System;
using System.Collections.Generic;
using System.Text;
using Dal.Interface;

namespace Logic.Interface
{
    public interface IViewableCategory
    {
        public int CatID { get; }
        public string Name { get; }
        
        public CategoryDTO ConvertToDto()
        {
            return new CategoryDTO(CatID, Name);
        }
    }
}
