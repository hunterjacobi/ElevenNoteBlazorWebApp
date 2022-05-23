using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElevenNoteWebApp.Server.Services.Categories;
using ElevenNoteWebApp.Shared.Models.Category;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElevenNoteWebApp.Server.Controllers
{
    //comment
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();
            return Ok(categories);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Category(int id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);

            if (category == null) return NotFound();
            return Ok(category);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreate model)
        {
            if (model == null || !ModelState.IsValid) return BadRequest();

            bool wasSuccessful = await _categoryService.CreateCategoryAsync(model);

            if (wasSuccessful) return Ok();
            return UnprocessableEntity();
        }

        // PUT api/values/5
        [HttpPut("edit/{id}")]
        public async Task<IActionResult> Edit(int id, CategoryEdit model)
        {
            if (model == null || !ModelState.IsValid) return BadRequest();
            if (model.Id != id) return BadRequest();

            bool wasSuccessful = await _categoryService.UpdateCategoryAsync(model);

            if (wasSuccessful) return Ok();
            return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);

            if (category == null) return NotFound();

            bool wasSuccessful = await _categoryService.DeleteCategoryAsync(id);

            if (!wasSuccessful) return BadRequest();

            return Ok();
        }
    }
}
