using AutoMapper;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Dto.AboutDtos;
using SignalRFastFood.Dto.DiscountDtos;

namespace SignalRFastFood.Business.Services.Mapping;

public class DiscountMapping : Profile
{
    public DiscountMapping()
    {
        CreateMap<Discount, CreateDiscountDto>().ReverseMap();
        CreateMap<Discount, UpdateAboutDto>().ReverseMap();
        CreateMap<Discount, ResultDiscountDto>().ReverseMap();
        CreateMap<Discount, GetDiscountDto>().ReverseMap();
    }
}