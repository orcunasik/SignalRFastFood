using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Dto.SocialMediaDtos;

namespace SignalRFastFood.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SocialMediasController : ControllerBase
{
    private readonly ISocialMediaService _socialMediaService;
    private readonly IMapper _mapper;

    public SocialMediasController(ISocialMediaService socialMediaService, IMapper mapper)
    {
        _socialMediaService = socialMediaService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        IList<SocialMedia> socialMedias = await _socialMediaService.GetAllAsync();
        IList<ResultSocialMediaDto> socialMediaDtos = _mapper.Map<IList<ResultSocialMediaDto>>(socialMedias);
        return Ok(socialMediaDtos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        SocialMedia socialMedia = await _socialMediaService.GetByIdAsync(id);
        GetSocialMediaDto socialMediaDto = _mapper.Map<GetSocialMediaDto>(socialMedia);
        return Ok(socialMediaDto);
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateSocialMediaDto socialMediaDto)
    {
        await _socialMediaService.AddAsync(_mapper.Map<SocialMedia>(socialMediaDto));
        return Ok("Sosyal Medya Bilgisi Başarı ile Eklendi");
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateSocialMediaDto socialMediaDto)
    {
        await _socialMediaService.UpdateAsync(_mapper.Map<SocialMedia>(socialMediaDto));
        return Ok("Sosyal Medya Bilgisi Başarı ile Güncellendi");
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        SocialMedia socialMedia = await _socialMediaService.GetByIdAsync(id);
        await _socialMediaService.RemoveAsync(socialMedia);
        return Ok("Sosyal Medya Bilgisi Başarı ile Silinmiştir");
    }
}