// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace web.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/ricksonsa/Projects/web/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ricksonsa/Projects/web/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ricksonsa/Projects/web/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ricksonsa/Projects/web/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/ricksonsa/Projects/web/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/ricksonsa/Projects/web/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/ricksonsa/Projects/web/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/ricksonsa/Projects/web/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/ricksonsa/Projects/web/Client/_Imports.razor"
using web.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/ricksonsa/Projects/web/Client/_Imports.razor"
using web.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ricksonsa/Projects/web/Client/Pages/Earnings.razor"
using web.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ricksonsa/Projects/web/Client/Pages/Earnings.razor"
using web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/earnings")]
    public partial class Earnings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "/Users/ricksonsa/Projects/web/Client/Pages/Earnings.razor"
       
    private IList<EarningModel> earnings;

    void OnSubmitHandler(EarningModel earning)
    {
        earnings.Add(earning);
        StateHasChanged();
    }

    protected override async Task OnInitializedAsync()
    {
        earnings = await Http.GetFromJsonAsync<EarningModel[]>("api/earnings");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
