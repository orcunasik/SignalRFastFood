using Microsoft.AspNetCore.Mvc;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Services.Abstracts;

namespace SignalRFastFood.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        IList<Category> categories = await _categoryService.GetAllAsync();
        return Ok(categories);
    }
}