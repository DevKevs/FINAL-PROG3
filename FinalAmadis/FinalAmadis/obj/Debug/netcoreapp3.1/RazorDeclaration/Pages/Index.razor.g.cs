#pragma checksum "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02873f8b3ad36b9ac641d9b07bb3a0bf484104b2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FinalAmadis.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using FinalAmadis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using FinalAmadis.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
using FinalAmadis.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
      
    string eliminar;
    public dynamic Datos { get; set; }
    protected override async Task OnInitializedAsync()
    {
        try
        {
            Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Seleccionar_Todo");
            WebClient client = new WebClient();
            var data = await client.DownloadStringTaskAsync(url);
            Datos = JsonConvert.DeserializeObject(data);
        }
        catch (Exception)
        {

            throw;
        }

    }

    public async Task<string> data(string eliminr)
    {
        if (eliminr != null)
        {
            await Task.Delay(10);
            eliminar = eliminr;
        }
        return null;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
