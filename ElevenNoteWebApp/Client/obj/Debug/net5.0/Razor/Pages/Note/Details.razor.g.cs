#pragma checksum "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0170200b72db1f202b9f196e4fe49d5817d8cb16"
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
#line 2 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
using ElevenNoteWebApp.Shared.Models.Note;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/note/{NoteId:int}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Note #");
            __builder.AddContent(2, 
#nullable restore
#line 6 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
           NoteId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 8 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
 if (Note != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-header d-flex justify-content-between");
            __builder.OpenElement(9, "span");
            __builder.AddContent(10, "Note #");
            __builder.AddContent(11, 
#nullable restore
#line 13 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
                                         Note.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                            ");
            __builder.OpenElement(13, "span");
            __builder.AddAttribute(14, "class", "text-muted");
            __builder.OpenElement(15, "strong");
            __builder.AddContent(16, 
#nullable restore
#line 14 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
                                                              Note.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card-body");
            __builder.OpenElement(20, "h4");
            __builder.AddAttribute(21, "class", "card-title");
            __builder.AddContent(22, 
#nullable restore
#line 17 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
                                                    Note.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                            ");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "class", "card-text");
            __builder.AddContent(26, 
#nullable restore
#line 18 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
                                                  Note.Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n                        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "card-footer text-muted d-flex justify-content-between");
            __builder.OpenElement(30, "span");
            __builder.AddAttribute(31, "class", "text-left");
            __builder.AddContent(32, "Created: ");
            __builder.AddContent(33, 
#nullable restore
#line 21 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
                                                              Note.CreatedUtc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 22 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
                             if (Note.ModifiedUtc != null)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "span");
            __builder.AddAttribute(35, "class", "text-right");
            __builder.AddContent(36, "Modified: ");
            __builder.AddContent(37, 
#nullable restore
#line 24 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
                                                                    Note.ModifiedUtc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 25 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "d-flex justify-content-center mt-3");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "text-center justify-content-between w-25");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "href", 
#nullable restore
#line 30 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
                                      $"/note/edit/{NoteId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(45, "class", "btn btn-outline-primary");
            __builder.AddContent(46, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                            ");
            __builder.OpenElement(48, "a");
            __builder.AddAttribute(49, "href", 
#nullable restore
#line 31 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
                                      $"/note/delete/{NoteId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(50, "class", "btn btn-outline-danger");
            __builder.AddContent(51, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n                            <hr>\n                            ");
            __builder.AddMarkupContent(53, "<a href=\"/note\">Back to the Notes Index</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
            }
 else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(54, "<p>Loading...</p>");
#nullable restore
#line 41 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
            }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Note/Details.razor"
       
    [Parameter]
    public int NoteId { get; set; }
    public NoteDetail Note { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Note = await http.GetFromJsonAsync<NoteDetail>($"/api/note/{NoteId}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
