using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Dto.FeatureDtos;

namespace SignalRFastFood.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FeaturesController : ControllerBase
{
    private readonly IFeatureService _featureService;
    private readonly IMapper _mapper;

    public FeaturesController(IFeatureService featureService, IMapper mapper)
    {
        _featureService = featureService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        IList<Feature> features = await _featureService.GetAllAsync();
        IList<ResultFeatureDto> featureDtos = _mapper.Map<IList<ResultFeatureDto>>(features);
        return Ok(featureDtos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        Feature feature = await _featureService.GetByIdAsync(id);
        GetFeatureDto featureDto = _mapper.Map<GetFeatureDto>(feature);
        return Ok(featureDto);
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateFeatureDto featureDto)
    {
        await _featureService.AddAsync(_mapper.Map<Feature>(featureDto));
        return Ok("Öne Çıkan Bilgisi Başarı ile Eklendi");
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateFeatureDto featureDto)
    {
        await _featureService.UpdateAsync(_mapper.Map<Feature>(featureDto));
        return Ok("Öne Çıkan Bilgisi Başarı ile Güncellendi");
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        Feature feature = await _featureService.GetByIdAsync(id);
        await _featureService.RemoveAsync(feature);
        return Ok("Öne Çıkan Bilgisi Başarı ile Silinmiştir");
    }
}