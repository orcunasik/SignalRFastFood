using AutoMapper;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Dto.BookingDtos;

namespace SignalRFastFood.Business.Services.Mapping;

public class BookingMapping : Profile
{
    public BookingMapping()
    {
        CreateMap<Booking, CreateBookingDto>().ReverseMap();
        CreateMap<Booking, UpdateBookingDto>().ReverseMap();
        CreateMap<Booking, ResultBookingDto>().ReverseMap();
        CreateMap<Booking, GetBookingDto>().ReverseMap();
    }
}