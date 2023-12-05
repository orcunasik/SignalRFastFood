using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Dto.AboutDtos;

namespace SignalRFastFood.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AboutsController : ControllerBase
{
    private readonly IAboutService _aboutService;
    private readonly IMapper _mapper;

    public AboutsController(IAboutService aboutService, IMapper mapper)
    {
        _aboutService = aboutService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        IList<About> abouts = await _aboutService.GetAllAsync();
        IList<ResultAboutDto> aboutDtos = _mapper.Map<IList<ResultAboutDto>>(abouts);
        return Ok(aboutDtos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        About about = await _aboutService.GetByIdAsync(id);
        GetAboutDto aboutDto = _mapper.Map<GetAboutDto>(about);
        return Ok(aboutDto);
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateAboutDto aboutDto)
    {
        await _aboutService.AddAsync(_mapper.Map<About>(aboutDto));
        return Ok("Hakkımızda Bilgisi Başarı ile Eklendi");
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateAboutDto aboutDto)
    {
        await _aboutService.UpdateAsync(_mapper.Map<About>(aboutDto));
        return Ok("Hakkımızda Bilgisi Başarı ile Güncellendi");
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        About about = await _aboutService.GetByIdAsync(id);
        await _aboutService.RemoveAsync(about);
        return Ok("Hakkımızda Bilgisi Başarı ile Silinmiştir");
    }
}