using AutoMapper;
using HotelListing01.Data;
using HotelListing01.Models;

namespace HotelListing01.Configurations
{
    public class MapperInitializer: Profile
    {
        public MapperInitializer()
        {
            CreateMap<Country, countryDTO>().ReverseMap();
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Hotel, HotelDTO>().ReverseMap();
            CreateMap<Hotel, CreateHotelDTO>().ReverseMap();
        }
    }
}
