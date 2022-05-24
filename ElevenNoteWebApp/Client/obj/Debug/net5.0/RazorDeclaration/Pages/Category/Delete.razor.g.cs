// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ElevenNoteWebApp.Client.Pages.Category
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
#line 2 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Category/Delete.razor"
using ElevenNoteWebApp.Shared.Models.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Category/Delete.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/category/delete/{CategoryId:int}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/Users/guccigod/Documents/SD134ImmersionFT/11NoteWebApp/ElevenNoteWebApp/ElevenNoteWebApp/Client/Pages/Category/Delete.razor"
       
    [Parameter]
    public int CategoryId { get; set; }
    public CategoryDetail Category { get; set; }
    public string errorMessage { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Category = await http.GetFromJsonAsync<CategoryDetail>($"/api/category/{CategoryId}");
    }

    private async void HandleClick()
    {
        var deleteRes = await http.DeleteAsync($"/api/category/{CategoryId}");

        if (deleteRes.IsSuccessStatusCode)
        {
            navigation.NavigateTo("/category");
        }
        else
        {
            errorMessage = "Failed to delete your category.";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
