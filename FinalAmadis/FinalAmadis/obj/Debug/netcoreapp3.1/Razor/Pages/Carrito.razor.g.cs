#pragma checksum "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Carrito.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36949d0a60612ec60cfecca71b1d65da9c4a8dca"
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
#line 2 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Carrito.razor"
using FinalAmadis.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Carrito.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Carrito.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tienda/Carrito")]
    public partial class Carrito : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "box-shadow: rgba(100, 100, 111, 0.2) 0px 7px 29px 0px;");
            __builder.AddAttribute(2, "class", "container mt-2 p-3 rounded cart");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row no-gutters");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-8");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "product-details mr-2");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddMarkupContent(13, "<div style=\"cursor:pointer;\" class=\"d-flex flex-row align-items-center\"><a href=\"/Tienda\"><i class=\"fa fa-long-arrow-left\"></i><span class=\"ml-2\">Continuar comprando</span></a></div>\r\n                <hr>\r\n                ");
            __builder.AddMarkupContent(14, "<h6 class=\"mb-0\">Carrito de compras</h6>\r\n                ");
            __builder.AddMarkupContent(15, @"<div class=""d-flex justify-content-between"">
                    <span>Tienes ""VARIABLE"" productos en tu carrito </span>
                    <div class=""d-flex flex-row align-items-center"">
                        <span class=""text-black-50"">Filtrar por:</span>
                        <div class=""price ml-2""><span class=""mr-1"">precio</span><i class=""fa fa-angle-down""></i></div>
                    </div>
                </div>
");
#nullable restore
#line 21 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Carrito.razor"
                 if (Datos != null)
                {
                    foreach (var i in Datos)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "d-flex justify-content-between align-items-center mt-3 p-2 items rounded");
            __builder.AddMarkupContent(19, "\r\n                            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "d-flex flex-row");
            __builder.AddMarkupContent(22, "\r\n                                ");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "class", "rounded");
            __builder.AddAttribute(25, "src", 
#nullable restore
#line 27 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Carrito.razor"
                                                           i.Foto

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "width", "40");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "ml-2");
            __builder.OpenElement(30, "span");
            __builder.AddAttribute(31, "class", "font-weight-bold d-block");
            __builder.AddContent(32, 
#nullable restore
#line 28 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Carrito.razor"
                                                                                          i.Nombre_producto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(33, "span");
            __builder.AddAttribute(34, "class", "spec");
            __builder.AddContent(35, 
#nullable restore
#line 28 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Carrito.razor"
                                                                                                                                      i.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "d-flex flex-row align-items-center");
            __builder.OpenElement(40, "span");
            __builder.AddAttribute(41, "class", "d-block");
            __builder.AddContent(42, 
#nullable restore
#line 30 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Carrito.razor"
                                                                                                   i.Cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(43, "span");
            __builder.AddAttribute(44, "class", "d-block ml-5 font-weight-bold");
            __builder.AddContent(45, "$");
            __builder.AddContent(46, 
#nullable restore
#line 30 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Carrito.razor"
                                                                                                                                                                  i.Suma_total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "<i style=\"cursor: pointer; color: red;\" class=\"fa fa-trash-o ml-3 text-red-50\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 32 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Carrito.razor"

                    }

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Carrito.razor"
                 if (Datos == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                    ");
            __builder.AddMarkupContent(51, "<div class=\"d-flex justify-content-center\">\r\n                        <div class=\"spinner-border\" role=\"status\">\r\n                            <span class=\"visually-hidden\"></span>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 43 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Carrito.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.AddMarkupContent(55, "<div style=\"box-shadow: rgba(100, 100, 111, 0.2) 0px 7px 29px 0px;\" class=\"col-md-4\">\r\n            <div class=\"payment-info\">\r\n                <div class=\"d-flex justify-content-between align-items-center\"><span>Detalles de tarjeta</span><i class=\"fas fa-user-circle\"></i></div><span class=\"type d-block mt-3 mb-1\">Tipo</span><label class=\"radio\"> <input type=\"radio\" name=\"card\" value=\"payment\" checked> <span><img width=\"30\" src=\"https://img.icons8.com/color/48/000000/mastercard.png\"></span> </label>\r\n                <label class=\"radio\"> <input type=\"radio\" name=\"card\" value=\"payment\"> <span><img width=\"30\" src=\"https://img.icons8.com/officel/48/000000/visa.png\"></span> </label>\r\n                <label class=\"radio\"> <input type=\"radio\" name=\"card\" value=\"payment\"> <span><img width=\"30\" src=\"https://img.icons8.com/ultraviolet/48/000000/amex.png\"></span> </label>\r\n                <label class=\"radio\"> <input type=\"radio\" name=\"card\" value=\"payment\"> <span><img width=\"30\" src=\"https://img.icons8.com/officel/48/000000/paypal.png\"></span> </label>\r\n                <div><label class=\"credit-card-label\">Nombre del propietario</label><input type=\"text\" class=\"form-control credit-inputs\" placeholder=\"Nombre\"></div>\r\n                <div><label class=\"credit-card-label\">Numero de tarjeta</label><input type=\"text\" class=\"form-control credit-inputs\" placeholder=\"0000 0000 0000 0000\"></div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\"><label class=\"credit-card-label\">Fecha</label><input type=\"text\" class=\"form-control credit-inputs\" placeholder=\"12/24\"></div>\r\n                    <div class=\"col-md-6\"><label class=\"credit-card-label\">CVV</label><input type=\"text\" class=\"form-control credit-inputs\" placeholder=\"342\"></div>\r\n                </div>\r\n                <hr class=\"line\">\r\n                <div class=\"d-flex justify-content-between information\"><span>Subtotal</span><span>$\"VARIABLE\"</span></div>\r\n                <div class=\"d-flex justify-content-between information\"><span>Envío</span><span>$00.00</span></div>\r\n                <div class=\"d-flex justify-content-between information\"><span>Total(Incl. taxes)</span><span>$\"VARIABLE\"</span></div><button class=\"btn btn-info btn-block d-flex justify-content-between mt-3\" type=\"button\"><span>$\"VARIABLE\"</span><span>Pagar <i class=\"fa fa-long-arrow-right ml-1\"></i></span></button>\r\n            </div>\r\n        </div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.OpenElement(58, "label");
            __builder.AddContent(59, 
#nullable restore
#line 68 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Carrito.razor"
        myUrl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Carrito.razor"
       
    public dynamic Datos { get; set; }
    public dynamic StorageData { get; set; }
    string myUrl;

    //protected override async Task OnInitializedAsync()
    //{
    //    try
    //    {
    //        if (StorageData != null)
    //        {
    //            myUrl = "https://super-mini-market.herokuapp.com/api/Detalles_Carrito/" + StorageData.IdUsuario;
    //            Uri url = new Uri(myUrl);
    //            WebClient client = new WebClient();
    //            var data = await client.DownloadStringTaskAsync(url);
    //            Datos = JsonConvert.DeserializeObject(data);

    //        }
    //        else
    //        {

    //            var storage = await JSRuntime.InvokeAsync<string>("storagePicker");
    //            StorageData = JsonConvert.DeserializeObject(storage);
    //            StateHasChanged();
    //            await pruba();

    //        }




    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }

    //}
    async Task pruba()
    {
        try
        {
            myUrl = "https://super-mini-market.herokuapp.com/api/Detalles_Carrito/" + StorageData.IdUsuario;
            Uri url = new Uri(myUrl);
            WebClient client = new WebClient();
            var data = await client.DownloadStringTaskAsync(url);
            Datos = JsonConvert.DeserializeObject(data);

        }
        catch (Exception)
        {
            throw;
        }
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            try
            {
                var storage = await JSRuntime.InvokeAsync<string>("storagePicker");
                StorageData = JsonConvert.DeserializeObject(storage);

                myUrl = "https://super-mini-market.herokuapp.com/api/Detalles_Carrito/" + StorageData.IdUsuario;
                Uri url = new Uri(myUrl);
                WebClient client = new WebClient();
                var data = await client.DownloadStringTaskAsync(url);
                Datos = JsonConvert.DeserializeObject(data);
                StateHasChanged();


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    async Task ojo()
    {
        var storage = await JSRuntime.InvokeAsync<string>("storagePicker");
        StorageData = JsonConvert.DeserializeObject(storage);
        await pruba();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
