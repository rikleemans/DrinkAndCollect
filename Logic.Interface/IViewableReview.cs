using System;
using System.Collections.Generic;
using System.Text;
using Dal.Interface;

namespace Logic.Interface
{
    public interface IViewableReview
    {
        int ReviewID { get; }
        int UserID { get; }
        int BeerID { get; }
        int Rate { get; }
        string Taste { get; }
        string Description { get; }
        DateTime Datum { get; }
        public ReviewDTO ConvertToDto()
        {
            return new ReviewDTO(ReviewID, UserID, BeerID, Rate, Taste, Description, Datum);
        }
    }
}
