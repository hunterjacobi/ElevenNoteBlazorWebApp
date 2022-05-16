using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElevenNoteWebApp.Server.Data;
using ElevenNoteWebApp.Server.Models;
using ElevenNoteWebApp.Shared.Models.Category;
using Microsoft.EntityFrameworkCore;

namespace ElevenNoteWebApp.Server.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateCategoryAsync(CategoryCreate model)
        {
            if (model == null) return false;

            var categoryEntity = new Category
            {
                Name = model.Name
            };

            _context.Categories.Add(categoryEntity);

            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<bool> DeleteCategoryAsync(int categoryId)
        {
            var entity = await _context.Categories.FindAsync(categoryId);

            _context.Categories.Remove(entity);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<IEnumerable<CategoryListItem>> GetAllCategoriesAsync()
        {
            var categoryQuery =
                _context
                    .Categories
                    .Select(entity =>
                    new CategoryListItem
                    {
                        Id = entity.Id,
                        Name = entity.Name,
                    });

            return await categoryQuery.ToListAsync();
        }

        public Task<CategoryDetail> GetCategoryByIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateCategoryAsync(CategoryEdit model)
        {
            if (model == null) return false;

            var entity = await _context.Categories.FindAsync(model.Name);

            entity.Name = model.Name;

            return await _context.SaveChangesAsync() == 1;
        }
    }
}
