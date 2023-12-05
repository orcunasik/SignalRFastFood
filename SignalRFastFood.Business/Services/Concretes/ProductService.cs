using AutoMapper;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Core.UnitOfWorks;
using SignalRFastFood.Dto.ProductDtos;

namespace SignalRFastFood.Business.Services.Concretes;

public class ProductService : Service<Product>, IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    public ProductService(IRepository<Product> repository, IUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<IList<Product>> GetProductsWithCategoryAsync()
    {
        IList<Product> products = await _productRepository.GetProductsWithCategoryAsync();
        IList<ResultProductWithCategoryDto> productDtos = _mapper.Map<IList<ResultProductWithCategoryDto>>(products);
        return _mapper.Map<IList<Product>>(productDtos);
    }
}