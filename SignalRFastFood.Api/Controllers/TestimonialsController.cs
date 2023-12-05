using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Dto.TestimonialDtos;

namespace SignalRFastFood.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestimonialsController : ControllerBase
{
    private readonly ITestimonialService _testimonialService;
    private readonly IMapper _mapper;

    public TestimonialsController(ITestimonialService testimonialService, IMapper mapper)
    {
        _testimonialService = testimonialService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        IList<Testimonial> testimonials = await _testimonialService.GetAllAsync();
        IList<ResultTestimonialDto> testimonialDtos = _mapper.Map<IList<ResultTestimonialDto>>(testimonials);
        return Ok(testimonialDtos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        Testimonial testimonial = await _testimonialService.GetByIdAsync(id);
        GetTestimonialDto testimonialDto = _mapper.Map<GetTestimonialDto>(testimonial);
        return Ok(testimonialDto);
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateTestimonialDto testimonialDto)
    {
        await _testimonialService.AddAsync(_mapper.Map<Testimonial>(testimonialDto));
        return Ok("Referans Bilgisi Başarı ile Eklendi");
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateTestimonialDto testimonialDto)
    {
        await _testimonialService.UpdateAsync(_mapper.Map<Testimonial>(testimonialDto));
        return Ok("Referans Bilgisi Başarı ile Güncellendi");
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        Testimonial testimonial = await _testimonialService.GetByIdAsync(id);
        await _testimonialService.RemoveAsync(testimonial);
        return Ok("Referans Bilgisi Başarı ile Silinmiştir");
    }
}