using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ElevenNoteWebApp.Shared.Models.Note;

namespace ElevenNoteWebApp.Server.Services.Notes
{
    public interface INoteService
    {
        Task<IEnumerable<NoteListItem>> GetAllNotesAsync();
        Task<bool> CreateNoteAsync(NoteCreate model);
        Task<NoteDetail> GetNoteByIdAsync(int noteId);
        Task<bool> UpdateNoteAsync(NoteEdit model);
        Task<bool> DeleteNoteAsync(int noteId);
        void SetUserId(string userId);
    }
}
