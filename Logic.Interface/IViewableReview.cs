using System;
using System.Collections.Generic;
using System.Text;
using Dal.Interface;

namespace Logic.Interface
{
    public interface IViewableReview
    {
       public int ReviewID { get; }
       public string UserID { get; }
        public int BeerID { get; }
        public int Rate { get; }
        public string Taste { get; }
        public string Description { get; }
        public DateTime Datum { get; }
        public ReviewDTO ConvertToDto()
        {
            return new ReviewDTO(ReviewID, UserID, BeerID, Rate, Taste, Description, Datum);
        }
    }
}
