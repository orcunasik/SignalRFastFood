using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Dto.BookingDtos;

namespace SignalRFastFood.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookingsController : ControllerBase
{
    private readonly IBookingService _bookingService;

    private readonly IMapper _mapper;
    public BookingsController(IBookingService bookingService, IMapper mapper)
    {
        _bookingService = bookingService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        IList<Booking> bookings = await _bookingService.GetAllAsync();
        IList<ResultBookingDto> bookingDtos = _mapper.Map<IList<ResultBookingDto>>(bookings);
        return Ok(bookingDtos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        Booking booking = await _bookingService.GetByIdAsync(id);
        GetBookingDto bookingDto = _mapper.Map<GetBookingDto>(booking);
        return Ok(bookingDto);
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateBookingDto bookingDto)
    {
        await _bookingService.AddAsync(_mapper.Map<Booking>(bookingDto));
        return Ok("Rezervasyon Bilgisi Başarı ile Eklendi");
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateBookingDto bookingDto)
    {
        await _bookingService.UpdateAsync(_mapper.Map<Booking>(bookingDto));
        return Ok("Rezervasyon Bilgisi Başarı ile Güncellendi");
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        Booking booking = await _bookingService.GetByIdAsync(id);
        await _bookingService.RemoveAsync(booking);
        return Ok("Rezervasyon Bilgisi Başarı ile Silinmiştir");
    }
}