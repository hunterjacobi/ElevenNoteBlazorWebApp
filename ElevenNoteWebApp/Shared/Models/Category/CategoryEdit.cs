using System;
using System.ComponentModel.DataAnnotations;

namespace ElevenNoteWebApp.Shared.Models.Category
{
    public class CategoryEdit
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
