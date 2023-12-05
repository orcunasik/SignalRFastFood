using AutoMapper;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Dto.ContactDtos;

namespace SignalRFastFood.Business.Mapping;

public class ContactMapping : Profile
{
    public ContactMapping()
    {
        CreateMap<Contact, CreateContactDto>().ReverseMap();
        CreateMap<Contact, UpdateContactDto>().ReverseMap();
        CreateMap<Contact, ResultContactDto>().ReverseMap();
        CreateMap<Contact, GetContactDto>().ReverseMap();
    }
}