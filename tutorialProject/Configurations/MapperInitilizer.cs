using AutoMapper;
using tutorialProject.DTOs;
using tutorialProject.Models;

namespace tutorialProject.Configurations
{
    public class MapperInitilizer : Profile
    {
       public MapperInitilizer()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Hotel, HotelDTO>().ReverseMap();
            CreateMap<Hotel, CreateHotelDTO>().ReverseMap();
        }
    }
}
