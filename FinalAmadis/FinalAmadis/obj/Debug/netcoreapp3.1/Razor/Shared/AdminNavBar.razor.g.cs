#pragma checksum "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a59b75c2d5cd9ea61d751c9b3dcb43c25f9aa85"
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
#line 1 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    public partial class AdminNavBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "nav");
            __builder.AddAttribute(4, "id", "sidebar");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "sidebar-header");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 8 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor"
             if (StorageData != null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "                ");
            __builder.OpenElement(10, "h3");
            __builder.AddContent(11, 
#nullable restore
#line 10 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor"
                     StorageData.Rol

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 11 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "container");
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "ul");
            __builder.AddAttribute(19, "class", "list-unstyled components");
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.AddMarkupContent(21, "<p>Fusion Market</p>\r\n                    ");
            __builder.AddMarkupContent(22, "<li>\r\n                        <a href=\"/admin\">Home</a>\r\n                    </li>\r\n                    ");
            __builder.AddMarkupContent(23, "<li>\r\n                        <a href=\"/Productos\">Productos</a>\r\n                    </li>\r\n                    ");
            __builder.AddMarkupContent(24, "<li>\r\n                        <a href=\"/Categorias\">Categorías</a>\r\n                    </li>\r\n                    ");
            __builder.AddMarkupContent(25, "<li>\r\n                        <a href=\"/admin\">Pedidos</a>\r\n                    </li>\r\n                    ");
            __builder.AddMarkupContent(26, "<li>\r\n                        <a href=\"/admin\">Clientes</a>\r\n                    </li>\r\n");
#nullable restore
#line 31 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor"
                     if (StorageData != null)
                    {
                        if (StorageData.Rol == "SuperAdmin")
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                            ");
            __builder.AddMarkupContent(28, "<li>\r\n                                <a href=\"/Usuarios\">Usuarios</a>\r\n                            </li>\r\n");
#nullable restore
#line 38 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            \r\n\r\n            ");
            __builder.AddMarkupContent(32, "<ul class=\"list-unstyled CTAs\">\r\n                <li>\r\n                    <a href=\"/\" class=\"download\">Cerrar sesión</a>\r\n                </li>\r\n               \r\n            </ul>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor"
      
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
