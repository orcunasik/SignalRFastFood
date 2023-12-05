using AutoMapper;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Dto.CategoryDtos;

namespace SignalRFastFood.Business.Services.Mapping;

public class CategoryMapping : Profile
{
    public CategoryMapping()
    {
        CreateMap<Category, CreateCategoryDto>().ReverseMap();
        CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        CreateMap<Category, ResultCategoryDto>().ReverseMap();
        CreateMap<Category, GetCategoryDto>().ReverseMap();
    }
}