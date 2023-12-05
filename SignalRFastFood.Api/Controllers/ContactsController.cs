using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRFastFood.Business.Services.Concretes;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Dto.ContactDtos;

namespace SignalRFastFood.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactsController : ControllerBase
{
    private readonly IContactService _contactService;
    private readonly IMapper _mapper;

    public ContactsController(IContactService contactService, IMapper mapper)
    {
        _contactService = contactService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        IList<Contact> contacts = await _contactService.GetAllAsync();
        IList<ResultContactDto> contactDtos = _mapper.Map<IList<ResultContactDto>>(contacts);
        return Ok(contactDtos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        Contact contact = await _contactService.GetByIdAsync(id);
        GetContactDto contactDto = _mapper.Map<GetContactDto>(contact);
        return Ok(contactDto);
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateContactDto contactDto)
    {
        await _contactService.AddAsync(_mapper.Map<Contact>(contactDto));
        return Ok("İletişim Bilgisi Başarı ile Eklendi");
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateContactDto contactDto)
    {
        await _contactService.UpdateAsync(_mapper.Map<Contact>(contactDto));
        return Ok("İletişim Bilgisi Başarı ile Güncellendi");
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        Contact contact = await _contactService.GetByIdAsync(id);
        await _contactService.RemoveAsync(contact);
        return Ok("İletişim Bilgisi Başarı ile Silinmiştir");
    }
}