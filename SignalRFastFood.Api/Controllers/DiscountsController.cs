using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Dto.DiscountDtos;

namespace SignalRFastFood.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DiscountsController : ControllerBase
{
    private readonly IDiscountService _discountService;
    private readonly IMapper _mapper;

    public DiscountsController(IDiscountService discountService, IMapper mapper)
    {
        _discountService = discountService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        IList<Discount> discounts = await _discountService.GetAllAsync();
        IList<ResultDiscountDto> discountDtos = _mapper.Map<IList<ResultDiscountDto>>(discounts);
        return Ok(discountDtos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        Discount discount = await _discountService.GetByIdAsync(id);
        GetDiscountDto discountDto = _mapper.Map<GetDiscountDto>(discount);
        return Ok(discountDto);
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateDiscountDto discountDto)
    {
        await _discountService.AddAsync(_mapper.Map<Discount>(discountDto));
        return Ok("İndirim Bilgisi Başarı ile Eklendi");
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateDiscountDto discountDto)
    {
        await _discountService.UpdateAsync(_mapper.Map<Discount>(discountDto));
        return Ok("İndirim Bilgisi Başarı ile Güncellendi");
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        Discount discount = await _discountService.GetByIdAsync(id);
        await _discountService.RemoveAsync(discount);
        return Ok("İndirim Bilgisi Başarı ile Silinmiştir");
    }
}