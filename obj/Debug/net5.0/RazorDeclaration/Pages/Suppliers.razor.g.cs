// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Querys.Pages
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
#nullable restore
#line 3 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/Suppliers.razor"
using Querys.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/suppliers")]
    public partial class Suppliers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/Suppliers.razor"
       

    IEnumerable<SupplierProducts> supplierProducts;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        GetSupplier();
    }

    void GetSupplier()
    {
        var query = from s in context.Suppliers
                    join p in context.Products on s.Id.ToString() equals p.SupplierIds
                    group p by new { s.Id, s.Company } into g
                    select new SupplierProducts
                    {
                        Id = g.Key.Id,
                        Company = g.Key.Company,
                        Products = g.Count()
                    };

        supplierProducts = query.ToList().OrderByDescending(sp => sp.Products);
    }

    int GetIds(string value)
    {
        string[] idstring = value.Split(';', StringSplitOptions.TrimEntries);
        int[] idint = new int[idstring.Count()];

        foreach (string id in idstring)
        {
            idint.Append(int.Parse(id));
        }

        return idint[0];
    }

    class SupplierProducts
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public int Products { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private northwindContext context { get; set; }
    }
}
#pragma warning restore 1591
