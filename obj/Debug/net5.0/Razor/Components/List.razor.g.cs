#pragma checksum "/Users/alejandro/Itla/C5/prog_3/tarea_5/Components/List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02713617925f93deea396385ba8191fe9e8d8171"
// <auto-generated/>
#pragma warning disable 1591
namespace Querys.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Querys;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Querys.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Querys.Models;

#line default
#line hidden
#nullable disable
    public partial class List : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "li");
            __builder.AddAttribute(1, "b-118edhw3zf");
            __builder.OpenElement(2, "span");
            __builder.AddAttribute(3, "class", "name");
            __builder.AddAttribute(4, "b-118edhw3zf");
            __builder.AddContent(5, 
#nullable restore
#line 2 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Components/List.razor"
                        Bold

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(6, " ");
            __builder.AddContent(7, 
#nullable restore
#line 2 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Components/List.razor"
                                     Thin

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Components/List.razor"
       
    [Parameter] public RenderFragment Bold { get; set; }
    [Parameter] public RenderFragment Thin { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591