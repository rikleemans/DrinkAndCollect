using System.Collections.Generic;
using Dal.Factory;
using Dal.Interface;
using Dal.Interface.Enums;
using Org.BouncyCastle.Asn1.X509;

namespace Logic
{
    public class Beer
    {
        #region properties

            public string Name { get; }
            public string BeerDescription { get; }

            public Style.style Style { get; }

            #endregion

            private readonly IBeer _dal;
            private readonly List<Beer> _Beer = new List<Beer>();
             public Beer(string name, string beerdescription, string style)
            {
                _dal = BeerFactory.CreateBeerDal();
                Name = name;
                BeerDescription = beerdescription;
                Style = style;
            }

            public Beer(BeerDTO dto)
            {
                Name = dto.Name;
                BeerDescription = dto.BeerDescription;
                Style = dto.style;
            }

            public void UpdateBeer(string name, string beerdescription, string style)
            {

                var Beer = new Beer(name, beerdescription, style);
                _Beer.Add(Beer);
                _dal.UpdateBeer(Beer.ConvertToDto());
            }

            public BeerDTO ConvertToDto()
            {
                return new BeerDTO(Name, BeerDescription, Style);
            }
        }
    }

