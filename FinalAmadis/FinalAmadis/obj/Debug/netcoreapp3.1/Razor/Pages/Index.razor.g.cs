#pragma checksum "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6b0dfe8f8d8c6b73fe32959ad3a5cd8d37bcd57"
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
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tienda")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    p {\r\n        color: black;\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid mt-2");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "id", "carouselExampleCaptions");
            __builder.AddAttribute(6, "class", "carousel slide");
            __builder.AddAttribute(7, "data-ride", "carousel");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "ol");
            __builder.AddAttribute(10, "class", "carousel-indicators");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 16 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
             if (sliderData != null)
            {

                int cont = 0;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                 foreach (var i in sliderData)
                {

                    var itemDinamico = cont++ == 0 ? "active" : "";

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                    ");
            __builder.OpenElement(13, "li");
            __builder.AddAttribute(14, "data-target", "#carouselExampleCaptions");
            __builder.AddAttribute(15, "data-slide-to", 
#nullable restore
#line 24 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                                                               cont

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "class", 
#nullable restore
#line 24 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                                                                             itemDinamico

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 25 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                 

            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "carousel-inner");
            __builder.AddMarkupContent(22, "\r\n\r\n");
#nullable restore
#line 31 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
             if (sliderData != null)
            {
                int cont = 0;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                 foreach (var i in sliderData)
                {

                    var itemDinamico = cont++ == 0 ? "carousel-item active" : "carousel-item";

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", 
#nullable restore
#line 38 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                 itemDinamico

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "img");
            __builder.AddAttribute(28, "height", "300");
            __builder.AddAttribute(29, "src", 
#nullable restore
#line 39 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                                i.Recurso

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "class", "img-fluid d-block w-100");
            __builder.AddAttribute(31, "alt", "...");
            __builder.AddAttribute(32, "style", "border-radius: 5px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "carousel-caption d-none d-md-block");
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "h5");
            __builder.AddContent(38, 
#nullable restore
#line 41 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                 i.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 44 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                 

            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "                ");
            __builder.AddMarkupContent(43, "<div class=\"d-flex justify-content-center\">\r\n                    <div class=\"spinner-border\" role=\"status\">\r\n                        <span class=\"visually-hidden\"></span>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 54 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.AddMarkupContent(46, "<a class=\"carousel-control-prev\" href=\"#carouselExampleCaptions\" role=\"button\" data-slide=\"prev\">\r\n            <span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\r\n            <span class=\"sr-only\">Previous</span>\r\n        </a>\r\n        ");
            __builder.AddMarkupContent(47, "<a class=\"carousel-control-next\" href=\"#carouselExampleCaptions\" role=\"button\" data-slide=\"next\">\r\n            <span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n            <span class=\"sr-only\">Next</span>\r\n        </a>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    <hr>\r\n\r\n    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "row");
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "col-sm");
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.AddMarkupContent(55, "<label for=\"categorias\"> Filtrar por:</label>\r\n            ");
            __builder.OpenElement(56, "select");
            __builder.AddAttribute(57, "id", "Drop");
            __builder.AddAttribute(58, "name", "categorias");
            __builder.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                                           Filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "class", "form-control w-25");
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "option");
            __builder.AddAttribute(63, "value", "Todos");
            __builder.AddAttribute(64, "selected", true);
            __builder.AddContent(65, "Categorias");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 72 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                 if (Drop != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                     foreach (var i in Drop)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                        ");
            __builder.OpenElement(68, "option");
            __builder.AddAttribute(69, "value", 
#nullable restore
#line 76 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                        i.Nombre_Categoria

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(70, " ");
            __builder.AddContent(71, 
#nullable restore
#line 76 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                                              i.Nombre_Categoria

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 77 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "                    ");
            __builder.OpenElement(74, "option");
            __builder.AddAttribute(75, "value", true);
            __builder.AddAttribute(76, "disabled", true);
            __builder.AddAttribute(77, "selected", true);
            __builder.AddContent(78, "Cargando...");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 82 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n\r\n    ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "row mt-4 mb-5");
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 88 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
         if (Datos != null && Datos.ok != false)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
             foreach (var i in Datos.data)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "                ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "col p-2");
            __builder.AddMarkupContent(90, "\r\n                    ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "card p-4");
            __builder.AddMarkupContent(93, "\r\n                        ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "card-body");
            __builder.AddAttribute(96, "style", "height: 375px; width: 280px");
            __builder.AddMarkupContent(97, "\r\n                            ");
            __builder.OpenElement(98, "img");
            __builder.AddAttribute(99, "class", "img-fluid mb-2");
            __builder.AddAttribute(100, "src", 
#nullable restore
#line 95 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                                              i.Foto_producto

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(101, "alt", "Alternate Text");
            __builder.AddAttribute(102, "style", "width: 85%;");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                            ");
            __builder.OpenElement(104, "h5");
            __builder.AddContent(105, 
#nullable restore
#line 96 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                 i.Nombre_producto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                            ");
            __builder.OpenElement(107, "h6");
            __builder.AddContent(108, 
#nullable restore
#line 97 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                 i.Categoria_producto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                            ");
            __builder.OpenElement(110, "h6");
            __builder.AddContent(111, 
#nullable restore
#line 98 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                 i.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(112, " $RD");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                        ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "style", "background-color: transparent;");
            __builder.AddAttribute(117, "class", "card-footer");
            __builder.AddMarkupContent(118, "\r\n                            ");
            __builder.OpenElement(119, "button");
            __builder.AddAttribute(120, "title", "Añadir al carrito");
            __builder.AddAttribute(121, "data-toggle", "modal");
            __builder.AddAttribute(122, "data-target", "#AgregarProducto");
            __builder.AddAttribute(123, "class", "btn btn-primary w-100");
            __builder.AddAttribute(124, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                                                                                                                                           async () => await data(i)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(125, "<i class=\"fas fa-shopping-cart\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n");
#nullable restore
#line 105 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
             
        } 

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(130, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n");
#nullable restore
#line 110 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
 if (Datos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(133, "    ");
            __builder.AddMarkupContent(134, "<div class=\"d-flex justify-content-center\">\r\n        <div class=\"spinner-border\" role=\"status\">\r\n            <span class=\"visually-hidden\"></span>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 117 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
 if (alerta)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(135, "    ");
            __builder.AddMarkupContent(136, "<div class=\"alert alert-danger text-center\" role=\"alert\">\r\n        No se encontraron registros...\r\n    </div>\r\n");
#nullable restore
#line 123 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(137, "div");
            __builder.AddAttribute(138, "class", "modal fade");
            __builder.AddAttribute(139, "id", "AgregarProducto");
            __builder.AddAttribute(140, "tabindex", "-1");
            __builder.AddAttribute(141, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(142, "aria-hidden", "true");
            __builder.AddMarkupContent(143, "\r\n    ");
            __builder.OpenElement(144, "div");
            __builder.AddAttribute(145, "class", "modal-dialog modal-lg");
            __builder.AddMarkupContent(146, "\r\n        ");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "modal-content");
            __builder.AddMarkupContent(149, "\r\n            ");
            __builder.AddMarkupContent(150, @"<div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Agregar producto</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __builder.OpenElement(151, "div");
            __builder.AddAttribute(152, "class", "modal-body");
            __builder.AddMarkupContent(153, "\r\n                ");
            __builder.OpenElement(154, "div");
            __builder.AddAttribute(155, "class", "row");
            __builder.AddMarkupContent(156, "\r\n                    ");
            __builder.OpenElement(157, "div");
            __builder.AddAttribute(158, "class", "col-sm-6");
            __builder.AddMarkupContent(159, "\r\n                        ");
            __builder.OpenElement(160, "h4");
            __builder.AddContent(161, 
#nullable restore
#line 136 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                             productos.Nombre_producto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n                        ");
            __builder.OpenElement(163, "p");
            __builder.AddContent(164, 
#nullable restore
#line 137 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                            productos.Categoria_producto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n                        ");
            __builder.OpenElement(166, "p");
            __builder.AddContent(167, 
#nullable restore
#line 138 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                            productos.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(168, " $RD");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n                        <hr>\r\n                        ");
            __builder.OpenElement(170, "h6");
            __builder.AddAttribute(171, "class", "mb-3");
            __builder.AddContent(172, 
#nullable restore
#line 140 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                          productos.Stock

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(173, " Unidad/es disponible/es");
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n                    ");
            __builder.OpenElement(176, "div");
            __builder.AddAttribute(177, "class", "col");
            __builder.AddMarkupContent(178, "\r\n                        ");
            __builder.OpenElement(179, "img");
            __builder.AddAttribute(180, "class", "img-fluid ml-4");
            __builder.AddAttribute(181, "src", 
#nullable restore
#line 143 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                                          productos.Foto_producto

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(182, "style", "width: 85%; height: 85%;");
            __builder.AddAttribute(183, "alt", "producto");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(185, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n                ");
            __builder.OpenElement(187, "div");
            __builder.AddAttribute(188, "class", "row");
            __builder.AddMarkupContent(189, "\r\n                    ");
            __builder.OpenElement(190, "div");
            __builder.AddAttribute(191, "class", "col-sm-4");
            __builder.AddMarkupContent(192, "\r\n                        ");
            __builder.AddMarkupContent(193, "<label>Selecciona la cantidad</label>\r\n");
#nullable restore
#line 149 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                         if (productos.Stock != null)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(194, "                            ");
            __builder.OpenElement(195, "select");
            __builder.AddAttribute(196, "id", "Drop");
            __builder.AddAttribute(197, "class", "form-control");
            __builder.AddAttribute(198, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 151 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                                     cantidad

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(199, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cantidad = __value, cantidad));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(200, "\r\n\r\n");
#nullable restore
#line 153 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                 if (productos.Stock != null)
                                {
                                    for (int i = 1; i <= int.Parse(productos.Stock); i++)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(201, "                                        ");
            __builder.OpenElement(202, "option");
            __builder.AddAttribute(203, "value", 
#nullable restore
#line 157 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                                        i

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(204, " ");
            __builder.AddContent(205, 
#nullable restore
#line 157 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                                             i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(206, "\r\n");
#nullable restore
#line 158 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                    }
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(207, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(208, "\r\n");
#nullable restore
#line 161 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(209, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(210, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(211, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(212, "\r\n            ");
            __builder.OpenElement(213, "div");
            __builder.AddAttribute(214, "class", "modal-footer");
            __builder.AddMarkupContent(215, "\r\n                ");
            __builder.AddMarkupContent(216, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n                ");
            __builder.OpenElement(217, "button");
            __builder.AddAttribute(218, "type", "submit");
            __builder.AddAttribute(219, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 167 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
                                                AgregarAlCarrito

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(220, "class", "btn btn-primary");
            __builder.AddContent(221, "Agregar al carrito");
            __builder.CloseElement();
            __builder.AddMarkupContent(222, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(223, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(224, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(225, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 174 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\Index.razor"
      
    public dynamic Datos { get; set; }
    public dynamic Editable { get; set; }
    public dynamic Drop { get; set; }
    public AgregarProductos Carrito = new AgregarProductos();
    string filter;
    public string jsonString;
    bool alerta = false;
    public dynamic sliderData { get; set; }
    public dynamic StorageData { get; set; }
    RootProductos productos = new RootProductos();
    public int cantidad;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Seleccionar_Todo");
            WebClient client = new WebClient();
            var data = await client.DownloadStringTaskAsync(url);
            Datos = JsonConvert.DeserializeObject(data);
            await Slidermanagement();
            await DropItems();
        }
        catch (Exception)
        {

            throw;
        }
    }
    protected async Task Reload()
    {
        try
        {
            Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Seleccionar_Todo");
            WebClient client = new WebClient();
            var data = await client.DownloadStringTaskAsync(url);
            Datos = JsonConvert.DeserializeObject(data);
            await Slidermanagement();
            await DropItems();
        }
        catch (Exception)
        {

            throw;
        }
    }
    async Task Filter(ChangeEventArgs e)
    {
        try
        {
            if (e.Value.ToString() == "Todos")
            {
                await Reload();
            }
            else
            {
                alerta = false;
                Datos = null;
                Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Seleccion_Producto_Categoria/" + e.Value.ToString());
                WebClient client = new WebClient();
                var data = await client.DownloadStringTaskAsync(url);
                Datos = JsonConvert.DeserializeObject(data);

                if (Datos.ok == false)
                {
                    alerta = true;
                }
            }
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
                StateHasChanged();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    public async Task<dynamic> data(dynamic selected)
    {
        if (selected != null)
        {
            await Task.Delay(10);
            productos.IdProducto = selected.IdProducto;
            productos.Nombre_producto = selected.Nombre_producto;
            productos.Categoria_producto = selected.Categoria_producto;
            productos.Precio = selected.Precio;
            productos.Stock = selected.Stock;
            productos.Foto_producto = selected.Foto_producto;
            productos.Descripcion_producto = selected.Descripcion_producto;


        }
        return null;
    }
    async Task Slidermanagement()
    {

        try
        {
            Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Mostrar_Todos_Slides");
            WebClient client = new WebClient();
            var data = await client.DownloadStringTaskAsync(url);
            sliderData = JsonConvert.DeserializeObject(data);
        }
        catch (Exception)
        {

            throw;
        }
    }
    async Task DropItems()
    {
        Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Mostrar_Todas_Categoria");
        WebClient client = new WebClient();
        var data = await client.DownloadStringTaskAsync(url);
        Drop = JsonConvert.DeserializeObject(data);
    }
    async Task AgregarAlCarrito()
    {

        try
        {
            Carrito.IdUsuarios = Convert.ToInt32(StorageData.IdUsuario);
            Carrito.IdProducto = Convert.ToInt32(productos.IdProducto);
            Carrito.Nombre_producto = productos.Nombre_producto;
            Carrito.Cantidad = cantidad.ToString();
            Carrito.Suma_total = (Convert.ToInt32(productos.Precio) * cantidad).ToString();
            Carrito.Categoria = productos.Categoria_producto;
            Carrito.Descripcion = productos.Descripcion_producto;
            Carrito.Foto = productos.Foto_producto;
            Carrito.N_Stock = (Convert.ToInt32(productos.Stock) - cantidad).ToString();

            jsonString = JsonConvert.SerializeObject(Carrito);
            Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Registro_Carrito");
            WebClient client = new WebClient();
            var data = await client.UploadStringTaskAsync(url, jsonString);
            Editable = JsonConvert.DeserializeObject(data);
            if (Editable != null)
            {
                await Reload();
                Carrito = new AgregarProductos();
                Mensajes();
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
    private async Task Mensajes()
    {
        if (Editable.ok == true)
        {
            await JSRuntime.InvokeVoidAsync("Confirmar", "success", "¡Exito!", "Los datos se guardaron con exito!");
        }
        else
        {
            await JSRuntime.InvokeVoidAsync("Confirmar", "error", "Vaya!", "Ocurrio un error...");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
