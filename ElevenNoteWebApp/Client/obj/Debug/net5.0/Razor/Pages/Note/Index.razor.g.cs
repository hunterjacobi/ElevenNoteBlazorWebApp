#pragma checksum "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cd54462ceff8d878b938104ca87e4e503a7cfae"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>All Notes</h3>\n");
            __builder.AddMarkupContent(1, "<a href=\"/note/create\">Create a note</a>");
#nullable restore
#line 9 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Index.razor"
 if (notes == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Index.razor"
}
else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Title</th>\n                            <th>&nbsp;</th></tr></thead>\n                    ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 23 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Index.razor"
                         foreach (var note in notes)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.OpenElement(9, "strong");
            __builder.AddContent(10, 
#nullable restore
#line 26 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Index.razor"
                                             note.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n                                ");
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "href", 
#nullable restore
#line 28 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Index.razor"
                                              $"note/{note.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, "Details");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                                    ");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", 
#nullable restore
#line 29 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Index.razor"
                                              $"note/edit/{note.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                                    ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", 
#nullable restore
#line 30 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Index.razor"
                                              $"note/delete/{note.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Index.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Index.razor"
            }

#line default
#line hidden
#nullable disable
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
