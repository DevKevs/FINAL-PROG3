#pragma checksum "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d925cf669c899dd1b24d7c8d19a4420f1bf96477"
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
#line 1 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
using System.Net;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "ftco-section");
            __builder.AddAttribute(2, "style", "position: -webkit-sticky; position: sticky; top: 0; z-index: 999;");
            __builder.AddMarkupContent(3, "\r\n    \r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "nav");
            __builder.AddAttribute(8, "class", "navbar navbar-expand-lg ftco_navbar ftco-navbar-light");
            __builder.AddAttribute(9, "id", "ftco-navbar");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "container");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.AddMarkupContent(14, "<a class=\"navbar-brand\" href=\"/index\">Fusion Market | Mercado</a>\r\n                ");
            __builder.AddMarkupContent(15, @"<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#ftco-nav"" aria-controls=""ftco-nav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""fa fa-bars""></span> 
                </button>
                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "collapse navbar-collapse");
            __builder.AddAttribute(18, "id", "ftco-nav");
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "ul");
            __builder.AddAttribute(21, "class", "navbar-nav ml-auto mr-md-3");
            __builder.AddAttribute(22, "style", "justify-content: space-between;");
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.AddMarkupContent(24, "<li class=\"nav-item\"><a href=\"/index\" class=\"nav-link\">Pedidos <i class=\"fas fa-box-open\"></i></a></li>\r\n                        ");
            __builder.AddMarkupContent(25, "<li class=\"nav-item\"><a href=\"/Carrito\" class=\"nav-link\">Carrito <i class=\"fas fa-shopping-cart\"></i></a></li>\r\n                        \r\n                        ");
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "nav-item");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "href", "/index");
            __builder.AddAttribute(30, "class", "nav-link");
#nullable restore
#line 18 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
                                                                                if(StorageData != null){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "h6");
            __builder.AddContent(32, 
#nullable restore
#line 18 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
                                                                                                             StorageData.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(33, "  ");
            __builder.AddContent(34, 
#nullable restore
#line 18 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
                                                                                                                                  StorageData.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, " <i class=\"fas fa-user-circle\"></i>");
            __builder.CloseElement();
            __builder.AddContent(36, " ");
#nullable restore
#line 18 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
                                                                                                                                                                                               }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.AddMarkupContent(38, "<li class=\"nav-item\"><a href=\"/\" class=\"nav-link\">Cerrar sesión <i class=\"fas fa-sign-out-alt\"></i></a></li>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
      
    public dynamic StorageData { get; set; } = null;
    
    
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
