// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ElevenNoteWebApp.Client.Pages.Note
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/_Imports.razor"
using ElevenNoteWebApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/_Imports.razor"
using ElevenNoteWebApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Index.razor"
using ElevenNoteWebApp.Shared.Models.Note;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/note")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Index.razor"
       
    private IEnumerable<NoteListItem> notes;

    protected override async Task OnInitializedAsync()
    {
        notes = await http.GetFromJsonAsync<List<NoteListItem>>("/api/note");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
