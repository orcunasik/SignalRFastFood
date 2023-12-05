using AutoMapper;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Dto.AboutDtos;

namespace SignalRFastFood.Business.Mapping;

public class AboutMapping : Profile
{
    public AboutMapping()
    {
        CreateMap<About, CreateAboutDto>().ReverseMap();
        CreateMap<About, ResultAboutDto>().ReverseMap();
        CreateMap<About, UpdateAboutDto>().ReverseMap();
        CreateMap<About, GetAboutDto>().ReverseMap();
    }
}