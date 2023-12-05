using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Dto.ProductDtos;

namespace SignalRFastFood.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;

    public ProductsController(IProductService productService, IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        IList<Product> products = await _productService.GetProductsWithCategoryAsync();
        IList<ResultProductWithCategoryDto> productDtos = _mapper.Map<IList<ResultProductWithCategoryDto>>(products);
        return Ok(productDtos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        Product product = await _productService.GetByIdAsync(id);
        GetProductDto productDto = _mapper.Map<GetProductDto>(product);
        return Ok(productDto);
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateProductDto productDto)
    {
        await _productService.AddAsync(_mapper.Map<Product>(productDto));
        return Ok("Ürün Bilgisi Başarı ile Eklendi");
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateProductDto productDto)
    {
        await _productService.UpdateAsync(_mapper.Map<Product>(productDto));
        return Ok("Ürün Bilgisi Başarı ile Güncellendi");
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        Product product = await _productService.GetByIdAsync(id);
        await _productService.RemoveAsync(product);
        return Ok("Ürün Bilgisi Başarı ile Silinmiştir");
    }
}