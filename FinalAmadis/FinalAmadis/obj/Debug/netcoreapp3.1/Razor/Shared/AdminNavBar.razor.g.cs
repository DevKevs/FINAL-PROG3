#pragma checksum "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfe48922dfe460b1d88d5f3692ea60168dfbcd6f"
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
#line 1 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using FinalAmadis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using FinalAmadis.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Interop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor"
using System.Net;

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
#line 9 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor"
             if (StorageData != null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "                ");
            __builder.OpenElement(10, "h3");
            __builder.AddContent(11, 
#nullable restore
#line 11 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor"
                     StorageData.Rol

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 12 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "container");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "ul");
            __builder.AddAttribute(19, "class", "list-unstyled components");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.AddMarkupContent(21, "<p>Fusion Market</p>\r\n                ");
            __builder.AddMarkupContent(22, "<li>\r\n                    <a href=\"/admin\">Inicio</a>\r\n                </li>\r\n                ");
            __builder.AddMarkupContent(23, "<li>\r\n                    <a href=\"/Productos\">Productos</a>\r\n                </li>\r\n                ");
            __builder.AddMarkupContent(24, "<li>\r\n                    <a href=\"/Categorias\">Categorías</a>\r\n                </li>\r\n                ");
            __builder.AddMarkupContent(25, "<li>\r\n                    <a href=\"/Pedidos\">Pedidos</a>\r\n                </li>\r\n                ");
            __builder.AddMarkupContent(26, "<li>\r\n                    <a href=\"/Clientes\">Clientes</a>\r\n                </li>\r\n                ");
            __builder.AddMarkupContent(27, "<li>\r\n                    <a href=\"/Slider\">Slider</a>\r\n                </li>\r\n");
#nullable restore
#line 35 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor"
                 if (StorageData != null)
                {
                    if (StorageData.Rol == "SuperAdmin")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "                        ");
            __builder.AddMarkupContent(29, "<li>\r\n                            <a href=\"/Usuarios\">Usuarios</a>\r\n                        </li>\r\n");
#nullable restore
#line 42 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n\r\n        ");
            __builder.OpenElement(33, "ul");
            __builder.AddAttribute(34, "class", "list-unstyled CTAs");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "li");
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", "/");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor"
                                      CerrarSesion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "class", "download");
            __builder.AddMarkupContent(42, "Cerrar sesión");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\AdminNavBar.razor"
      
    public dynamic StorageData { get; set; }
    public dynamic Salir { get; set; }
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
    async Task CerrarSesion()
    {
        string myUrl = "https://super-mini-market.herokuapp.com/api/CerrarSesion/" + StorageData.IdUsuario;
        Uri url = new Uri(myUrl);
        WebClient client = new WebClient();
        var data = await client.UploadStringTaskAsync(url, "");
        Salir = JsonConvert.DeserializeObject(data);

        if (Salir != null)
        {
            await Task.Delay(1000);
            NavigationManager.NavigateTo("/");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
