#pragma checksum "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d04f838275410fa42ebc4d3330ffb3e4bd954dde"
// <auto-generated/>
#pragma warning disable 1591
namespace FinalAmadis.Shared
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
#line 10 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Interop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminLayout.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<FinalAmadis.Shared.AdminNavBar>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "id", "contentt");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container-fluid");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "nav");
            __builder.AddAttribute(9, "id", "navAdmin");
            __builder.AddAttribute(10, "class", "navbar navbar-expand-lg navbar-light bg-light");
            __builder.AddAttribute(11, "style", "position: -webkit-sticky; position: sticky; top: 0; z-index: 999;");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "container-fluid");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "collapse navbar-collapse");
            __builder.AddAttribute(18, "id", "navbarSupportedContent");
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "ul");
            __builder.AddAttribute(21, "class", "nav navbar-nav ml-auto");
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.AddMarkupContent(23, "<li class=\"nav-item active\">\r\n                            <a class=\"nav-link\" href=\"/admin\">Fusion Market</a>\r\n                        </li>\r\n                        ");
            __builder.OpenElement(24, "li");
            __builder.AddAttribute(25, "class", "nav-item");
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", "/MiAdmin");
            __builder.AddAttribute(29, "class", "nav-link");
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 18 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminLayout.razor"
                                 if (StorageData != null)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "                                    ");
            __builder.OpenElement(32, "h6");
            __builder.AddMarkupContent(33, "\r\n                                        ");
            __builder.AddContent(34, 
#nullable restore
#line 21 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminLayout.razor"
                                         StorageData.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(35, " ");
            __builder.AddContent(36, 
#nullable restore
#line 21 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminLayout.razor"
                                                             StorageData.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(37, " <i class=\"fas fa-user-circle\"></i>\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 23 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminLayout.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "container");
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.AddContent(50, 
#nullable restore
#line 32 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminLayout.razor"
      
    public dynamic StorageData { get; set; }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            try
            {
                var storage = await JSRuntime.InvokeAsync<string>("storagePicker");
                StorageData = JsonConvert.DeserializeObject(storage);
                StateHasChanged();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
