using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDTO> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDTO>()
            {
                new CityDTO()
                {
                    Id = 1,
                    Name = "Porto Alegre",
                    Description = "Capital dos gaúchos.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Gasômetro",
                            Description = "Usina do Gasômetro"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Laçador",
                            Description = "Estátua do Laçador"
                        }
                    }
                },
                new CityDTO()
                {
                    Id = 2,
                    Name = "Canoas",
                    Description = "A que tem a praça do avião.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Praça do Avião",
                            Description = "Praça na frente da prefeitura"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Parque Eduardo Gomes",
                            Description = "Conhecido como Parcão"
                        }
                    }
                },
                new CityDTO()
                {
                    Id = 3,
                    Name = "Osório",
                    Description = "Cidade dos cataventos",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Parque eólico",
                            Description = "Cataventos!"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Morro da Borússia",
                            Description = "Dá pra ver o mar"
                        }
                    }
                }
            };
        }
    }
}
