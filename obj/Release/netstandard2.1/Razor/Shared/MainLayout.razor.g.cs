#pragma checksum "C:\Users\Cole Bright\source\repos\PowerScheduler\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c694cadb51c96fcb97c8d7641eff8a057fa2ebb1"
// <auto-generated/>
#pragma warning disable 1591
namespace PowerScheduler.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using PowerScheduler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using PowerScheduler.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using PowerScheduler.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "main");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "content px-4");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddContent(8, 
#nullable restore
#line 9 "C:\Users\Cole Bright\source\repos\PowerScheduler\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
