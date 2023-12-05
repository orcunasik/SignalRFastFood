using AutoMapper;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Dto.FeatureDtos;

namespace SignalRFastFood.Business.Services.Mapping;

public class FeatureMapping : Profile
{
    public FeatureMapping()
    {
        CreateMap<Feature, CreateFeatureDto>().ReverseMap();
        CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
        CreateMap<Feature, ResultFeatureDto>().ReverseMap();
        CreateMap<Feature, GetFeatureDto>().ReverseMap();
    }
}