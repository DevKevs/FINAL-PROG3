#pragma checksum "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Carrito.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7ac50a5c8632a86929a8fda64277e8bb99a4809"
// <auto-generated/>
#pragma warning disable 1591
namespace FinalAmadis.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using FinalAmadis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using FinalAmadis.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Huascar\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Interop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tienda/Carrito")]
    public partial class Carrito : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div style=\"box-shadow: rgba(100, 100, 111, 0.2) 0px 7px 29px 0px;\" class=\"container mt-2 p-3 rounded cart\">\r\n    <div class=\"row no-gutters\">\r\n        <div class=\"col-md-8\">\r\n            <div class=\"product-details mr-2\">\r\n                <div style=\"cursor:pointer;\" class=\"d-flex flex-row align-items-center\"><a href=\"/Tienda\"><i class=\"fa fa-long-arrow-left\"></i><span class=\"ml-2\">Continuar comprando</span></a></div>\r\n                <hr>\r\n                <h6 class=\"mb-0\">Carrito de compras</h6>\r\n                <div class=\"d-flex justify-content-between\"><span>Tienes \"VARIABLE\" productos en tu carrito </span>\r\n                    <div class=\"d-flex flex-row align-items-center\"><span class=\"text-black-50\">Filtrar por:</span>\r\n                        <div class=\"price ml-2\"><span class=\"mr-1\">precio</span><i class=\"fa fa-angle-down\"></i></div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"d-flex justify-content-between align-items-center mt-3 p-2 items rounded\">\r\n                    <div class=\"d-flex flex-row\"><img class=\"rounded\" src=\"https://i.imgur.com/QRwjbm5.jpg\" width=\"40\">\r\n                        <div class=\"ml-2\"><span class=\"font-weight-bold d-block\">Iphone 11 pro</span><span class=\"spec\">256GB, Navy Blue</span></div>\r\n                    </div>\r\n                    <div class=\"d-flex flex-row align-items-center\"><span class=\"d-block\">2</span><span class=\"d-block ml-5 font-weight-bold\">$900</span><i style=\"cursor: pointer; color: red;\" class=\"fa fa-trash-o ml-3 text-red-50\"></i></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div style=\"box-shadow: rgba(100, 100, 111, 0.2) 0px 7px 29px 0px;\" class=\"col-md-4\">\r\n            <div class=\"payment-info\">\r\n                <div class=\"d-flex justify-content-between align-items-center\"><span>Detalles de tarjeta</span><i class=\"fas fa-user-circle\"></i></div><span class=\"type d-block mt-3 mb-1\">Tipo</span><label class=\"radio\"> <input type=\"radio\" name=\"card\" value=\"payment\" checked> <span><img width=\"30\" src=\"https://img.icons8.com/color/48/000000/mastercard.png\"></span> </label>\r\n                <label class=\"radio\"> <input type=\"radio\" name=\"card\" value=\"payment\"> <span><img width=\"30\" src=\"https://img.icons8.com/officel/48/000000/visa.png\"></span> </label>\r\n                <label class=\"radio\"> <input type=\"radio\" name=\"card\" value=\"payment\"> <span><img width=\"30\" src=\"https://img.icons8.com/ultraviolet/48/000000/amex.png\"></span> </label>\r\n                <label class=\"radio\"> <input type=\"radio\" name=\"card\" value=\"payment\"> <span><img width=\"30\" src=\"https://img.icons8.com/officel/48/000000/paypal.png\"></span> </label>\r\n                <div><label class=\"credit-card-label\">Nombre del propietario</label><input type=\"text\" class=\"form-control credit-inputs\" placeholder=\"Nombre\"></div>\r\n                <div><label class=\"credit-card-label\">Numero de tarjeta</label><input type=\"text\" class=\"form-control credit-inputs\" placeholder=\"0000 0000 0000 0000\"></div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\"><label class=\"credit-card-label\">Fecha</label><input type=\"text\" class=\"form-control credit-inputs\" placeholder=\"12/24\"></div>\r\n                    <div class=\"col-md-6\"><label class=\"credit-card-label\">CVV</label><input type=\"text\" class=\"form-control credit-inputs\" placeholder=\"342\"></div>\r\n                </div>\r\n                <hr class=\"line\">\r\n                <div class=\"d-flex justify-content-between information\"><span>Subtotal</span><span>$\"VARIABLE\"</span></div>\r\n                <div class=\"d-flex justify-content-between information\"><span>Envío</span><span>$00.00</span></div>\r\n                <div class=\"d-flex justify-content-between information\"><span>Total(Incl. taxes)</span><span>$\"VARIABLE\"</span></div><button class=\"btn btn-info btn-block d-flex justify-content-between mt-3\" type=\"button\"><span>$\"VARIABLE\"</span><span>Pagar <i class=\"fa fa-long-arrow-right ml-1\"></i></span></button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591