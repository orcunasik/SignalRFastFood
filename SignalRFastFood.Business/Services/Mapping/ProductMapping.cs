using AutoMapper;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Dto.ProductDtos;

namespace SignalRFastFood.Business.Services.Mapping;

public class ProductMapping : Profile
{
    public ProductMapping()
    {
        CreateMap<Product, CreateProductDto>().ReverseMap();
        CreateMap<Product, UpdateProductDto>().ReverseMap();
        CreateMap<Product, ResultProductDto>().ReverseMap();
        CreateMap<Product, ResultProductWithCategoryDto>().ReverseMap();
        CreateMap<Product, GetProductDto>().ReverseMap();
    }
}