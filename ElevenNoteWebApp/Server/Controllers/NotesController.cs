using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ElevenNoteWebApp.Server.Services.Notes;
using ElevenNoteWebApp.Shared.Models.Note;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElevenNoteWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INoteService _noteService;

        public NotesController(INoteService noteService)
        {
            _noteService = noteService;
        }

        private string GetUserId()
        {
            string userIdClaim = User.Claims.First(i => i.Type == ClaimTypes.NameIdentifier).Value;

            if (userIdClaim == null) return null;
            return userIdClaim;
        }

        private bool SetUserIdInService()
        {
            var userId = GetUserId();
            if (userId == null) return false;

            _noteService.SetUserId(userId);
            return true;
        }

        // GET: api/values
        [HttpGet]
        public async Task<List<NoteListItem>> Index()
        {
            if (!SetUserIdInService()) return new List<NoteListItem>();

            var notes = await _noteService.GetAllNotesAsync();
            return notes.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Note(int id)
        {
            if (!SetUserIdInService()) return Unauthorized();

            var note = await _noteService.GetNoteByIdAsync(id);

            if (note == null) return NotFound();

            return Ok(note);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Create(NoteCreate model)
        {
            if (model == null) return BadRequest();

            if (!SetUserIdInService()) return Unauthorized();

            bool wasSuccessful = await _noteService.CreateNoteAsync(model);

            if (wasSuccessful) return Ok();
            else return UnprocessableEntity();
        }

        // PUT api/values/5
        [HttpPut("edit/{id}")]
        public async Task<IActionResult> Edit(int id, NoteEdit model)
        {
            if (!SetUserIdInService()) return Unauthorized();

            if (model == null || !ModelState.IsValid) return BadRequest();

            if (model.Id != id) return BadRequest();

            bool wasSuccessful = await _noteService.UpdateNoteAsync(model);

            if (wasSuccessful) return Ok();
            return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!SetUserIdInService()) return Unauthorized();

            var note = await _noteService.GetNoteByIdAsync(id);

            if (note == null) return NotFound();

            bool wasSuccessful = await _noteService.DeleteNoteAsync(id);
            if (!wasSuccessful) return BadRequest();
            return Ok();
        }
    }
}
