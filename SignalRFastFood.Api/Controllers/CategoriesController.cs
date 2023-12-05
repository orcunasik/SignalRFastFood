using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Dto.CategoryDtos;

namespace SignalRFastFood.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    private readonly IMapper _mapper;

    public CategoriesController(ICategoryService categoryService, IMapper mapper)
    {
        _categoryService = categoryService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        IList<Category> categorys = await _categoryService.GetAllAsync();
        IList<ResultCategoryDto> categoryDtos = _mapper.Map<IList<ResultCategoryDto>>(categorys);
        return Ok(categoryDtos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        Category category = await _categoryService.GetByIdAsync(id);
        GetCategoryDto categoryDto = _mapper.Map<GetCategoryDto>(category);
        return Ok(categoryDto);
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateCategoryDto categoryDto)
    {
        await _categoryService.AddAsync(_mapper.Map<Category>(categoryDto));
        return Ok("Kategori Bilgisi Başarı ile Eklendi");
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateCategoryDto categoryDto)
    {
        await _categoryService.UpdateAsync(_mapper.Map<Category>(categoryDto));
        return Ok("Kategori Bilgisi Başarı ile Güncellendi");
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        Category category = await _categoryService.GetByIdAsync(id);
        await _categoryService.RemoveAsync(category);
        return Ok("Kategori Bilgisi Başarı ile Silinmiştir");
    }
}