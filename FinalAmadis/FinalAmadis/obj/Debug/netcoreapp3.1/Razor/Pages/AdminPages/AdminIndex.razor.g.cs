#pragma checksum "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad13b3b96914ec8e520cd193c8b7269f85c3667"
// <auto-generated/>
#pragma warning disable 1591
namespace FinalAmadis.Pages.AdminPages
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
#line 2 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
using ChartJs.Blazor.PieChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
using FinalAmadis.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class AdminIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 13 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
 if (Datos != null)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-12 col-sm-6 col-md-8");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.AddMarkupContent(10, "<div class=\"card-header\" style=\"background-color: #fff\">\r\n                    <h4>Pedidos en curso</h4>\r\n                </div>\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table table-dark table-borderless");
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.AddMarkupContent(17, @"<thead>
                            <tr>
                                <th>Cliente</th>
                                <th>Telefono</th>
                                <th>Estado</th>
                                <th class=""text-center"">Acciones</th>
                            </tr>
                        </thead>
                        ");
            __builder.OpenElement(18, "tbody");
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 33 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                             if (Pedidos != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                 foreach (var prov in Pedidos.data)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                                    ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\r\n                                        ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 38 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                             prov.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, " ");
            __builder.AddContent(26, 
#nullable restore
#line 38 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                                          prov.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                                        ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 39 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                             prov.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                                        ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 40 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                             prov.Estado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                                        ");
            __builder.OpenElement(34, "td");
            __builder.AddMarkupContent(35, "\r\n                                            ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "title", "Editar");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                                                               async()=> await data(prov)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "class", "btn btn-success mb-2");
            __builder.AddAttribute(40, "data-toggle", "modal");
            __builder.AddAttribute(41, "data-target", "#exampleModal2");
            __builder.AddMarkupContent(42, "<i class=\"fas fa-edit\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                                            ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "title", "ver producto");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                                                                     async()=> await data(prov)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "data-toggle", "modal");
            __builder.AddAttribute(48, "data-target", "#exampleModal3");
            __builder.AddAttribute(49, "class", "btn btn-info mb-2");
            __builder.AddMarkupContent(50, "<i class=\"fas fa-eye\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 46 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col-6 col-md-4");
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "card");
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.AddMarkupContent(66, "<div class=\"card-header\" style=\"background-color: #fff\">\r\n                    <h4>Actividad</h4>\r\n                </div>\r\n                ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "card-body ");
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.OpenComponent<ChartJs.Blazor.Chart>(70);
            __builder.AddAttribute(71, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.Common.ConfigBase>(
#nullable restore
#line 59 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                   _config

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.AddMarkupContent(75, @"<div class=""col p-0"">
                <div class=""card mt-1"">
                    <div class=""card-header"" style=""background-color: #fff"">
                        <h4>Disponible</h4>
                    </div>
                    <div class=""card-body"">
                        disponible
                    </div>
                </div>
            </div>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 74 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"


}

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
 if (Datos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "    ");
            __builder.AddMarkupContent(79, "<div class=\"d-flex justify-content-center\">\r\n        <div class=\"spinner-border\" role=\"status\">\r\n            <span class=\"visually-hidden\"></span>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 84 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(80, "\r\n");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "modal fade");
            __builder.AddAttribute(83, "id", "exampleModal2");
            __builder.AddAttribute(84, "tabindex", "-1");
            __builder.AddAttribute(85, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(86, "aria-hidden", "true");
            __builder.AddMarkupContent(87, "\r\n    ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "modal-dialog");
            __builder.AddMarkupContent(90, "\r\n        ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "modal-content");
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.AddMarkupContent(94, @"<div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Editar orden</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "modal-body");
            __builder.AddMarkupContent(97, "\r\n                ");
            __builder.OpenElement(98, "label");
            __builder.AddAttribute(99, "for", "Estado");
            __builder.AddContent(100, "Actualizar el pedido de ");
            __builder.AddContent(101, 
#nullable restore
#line 96 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                                             _actualizar.NombreCliente

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(103);
            __builder.AddAttribute(104, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 97 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                  _actualizar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 97 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                                               UpdateEstate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(106, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(107, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(108);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(109, "\r\n                    ");
                __Blazor.FinalAmadis.Pages.AdminPages.AdminIndex.TypeInference.CreateInputSelect_0(__builder2, 110, 111, "Estado", 112, "Drop", 113, "form-control", 114, 
#nullable restore
#line 99 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                                                       _actualizar.Estado

#line default
#line hidden
#nullable disable
                , 115, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _actualizar.Estado = __value, _actualizar.Estado)), 116, () => _actualizar.Estado, 117, (__builder3) => {
                    __builder3.AddMarkupContent(118, "\r\n                        ");
                    __builder3.AddMarkupContent(119, "<option value selected disabled>Seleccione el estado</option>\r\n                        ");
                    __builder3.AddMarkupContent(120, "<option value=\"En proceso\">En proceso</option>\r\n                        ");
                    __builder3.AddMarkupContent(121, "<option value=\"Enviado\">Enviado</option>\r\n                        ");
                    __builder3.AddMarkupContent(122, "<option value=\"Completado\">Completado</option>\r\n                    ");
                }
                );
                __builder2.AddMarkupContent(123, "\r\n                    ");
                __Blazor.FinalAmadis.Pages.AdminPages.AdminIndex.TypeInference.CreateValidationMessage_1(__builder2, 124, 125, 
#nullable restore
#line 105 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                             () => _actualizar.Estado

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(126, "\r\n                    ");
                __builder2.AddMarkupContent(127, @"<div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>
                        <button type=""submit"" class=""btn btn-primary"">Guardar</button>
                    </div>
                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(128, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n\r\n");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "modal fade");
            __builder.AddAttribute(135, "id", "exampleModal3");
            __builder.AddAttribute(136, "tabindex", "-1");
            __builder.AddAttribute(137, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(138, "aria-hidden", "true");
            __builder.AddMarkupContent(139, "\r\n    ");
            __builder.OpenElement(140, "div");
            __builder.AddAttribute(141, "class", "modal-dialog modal-lg");
            __builder.AddMarkupContent(142, "\r\n        ");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "modal-content");
            __builder.AddMarkupContent(145, "\r\n            ");
            __builder.AddMarkupContent(146, @"<div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Detalles de productos pagos</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "modal-body");
            __builder.AddMarkupContent(149, "\r\n                ");
            __builder.OpenElement(150, "h4");
            __builder.AddContent(151, "Productos pagados por ");
            __builder.AddContent(152, 
#nullable restore
#line 126 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                           _actualizar.NombreCliente

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n");
#nullable restore
#line 127 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                 if (Productos_pagos != null && Productos_pagos.ok == true)
                {
                    
                    foreach (var i in Productos_pagos.data)
                    {


#line default
#line hidden
#nullable disable
            __builder.AddContent(154, "                        ");
            __builder.OpenElement(155, "div");
            __builder.AddAttribute(156, "class", "d-flex justify-content-between align-items-center mt-3 p-2 items rounded");
            __builder.AddMarkupContent(157, "\r\n                            ");
            __builder.OpenElement(158, "div");
            __builder.AddAttribute(159, "class", "d-flex flex-row");
            __builder.AddMarkupContent(160, "\r\n                                ");
            __builder.OpenElement(161, "img");
            __builder.AddAttribute(162, "class", "rounded img-fluid");
            __builder.AddAttribute(163, "src", 
#nullable restore
#line 135 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                                                     i.Foto

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(164, "width", "50");
            __builder.AddAttribute(165, "height", "50");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                                ");
            __builder.OpenElement(167, "div");
            __builder.AddAttribute(168, "class", "ml-2");
            __builder.OpenElement(169, "span");
            __builder.AddAttribute(170, "class", "font-weight-bold d-block");
            __builder.AddContent(171, 
#nullable restore
#line 136 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                                                                          i.Nombre_producto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(172, "span");
            __builder.AddAttribute(173, "class", "spec");
            __builder.AddContent(174, 
#nullable restore
#line 136 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                                                                                                                      i.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n                            ");
            __builder.OpenElement(177, "div");
            __builder.AddAttribute(178, "class", "d-flex flex-row align-items-center");
            __builder.OpenElement(179, "span");
            __builder.AddAttribute(180, "class", "d-block");
            __builder.AddContent(181, 
#nullable restore
#line 138 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                                                                                   i.Cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(182, "span");
            __builder.AddAttribute(183, "class", "d-block ml-5 font-weight-bold");
            __builder.AddContent(184, "$");
            __builder.AddContent(185, 
#nullable restore
#line 138 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                                                                                                                                                  i.Suma_total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n");
#nullable restore
#line 140 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"

                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                 if(Productos_pagos == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(188, "                    ");
            __builder.AddMarkupContent(189, "<div class=\"d-flex justify-content-center\">\r\n                        <div class=\"spinner-border\" role=\"status\">\r\n                            <span class=\"visually-hidden\"></span>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 150 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(190, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n            ");
            __builder.AddMarkupContent(192, "<div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cerrar</button>\r\n            </div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 159 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
      

    public dynamic Datos { get; set; }
    public dynamic Pedidos { get; set; }
    public dynamic Editable { get; set; }
    public dynamic Productos_pagos { get; set; }
    string jsonString;
    Pago pedidos = new Pago();
    Api consume = new Api();
    Actualizar _actualizar = new Actualizar();
    private PieConfig _config;
    public string Buscar { get; set; }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Mostrar_Conectados");
            WebClient client = new WebClient();
            var data = await client.DownloadStringTaskAsync(url);
            Datos = JsonConvert.DeserializeObject(data);
            await LoadPedidos();
            LoadChart();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void LoadChart()
    {
        _config = new PieConfig
        {
            Options = new PieOptions
            {
                Responsive = true,
                Title = new OptionsTitle
                {
                    Display = true
                }
            }
        };

        foreach (string color in new[] { "Conectados", "Desconectados" })
        {
            _config.Data.Labels.Add(color);
        }
        int dato1 = Convert.ToInt32(Datos.Conectados[0]);
        int dato2 = Convert.ToInt32(Datos.Desconectados[0]);
        PieDataset<int> dataset = new PieDataset<int>(new[] { dato1, dato2 })
        {
            BackgroundColor = new[]
        {
            ColorUtil.ColorHexString(255, 99, 132), // Slice 1 aka "Red"
            ColorUtil.ColorHexString(255, 205, 86), // Slice 2 aka "Yellow"
            ColorUtil.ColorHexString(75, 192, 192), // Slice 3 aka "Green"
            ColorUtil.ColorHexString(54, 162, 235), // Slice 4 aka "Blue"
        }
        };

        _config.Data.Datasets.Add(dataset);
    }
    async Task LoadPedidos()
    {
        try
        {
            Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Seleccionar_Pedidos");
            WebClient client = new WebClient();
            var data = await client.DownloadStringTaskAsync(url);
            Pedidos = JsonConvert.DeserializeObject(data);

        }
        catch (Exception)
        {

            throw;
        }
    }
    class Actualizar
    {
        public string IdOrden { get; set; }

        [Required(ErrorMessage = "El estado es requerido")]
        public string Estado { get; set; }

        public string NombreCliente { get; set; }
    }
    public async Task<dynamic> data(dynamic select)
    {

        await Task.Delay(10);
        if (select != null)
        {
            pedidos.IdUsuario = select.IdUsuarios;
            pedidos.Estado = select.Estado;
            pedidos.Longitud = select.Longitud;
            pedidos.Latitud = select.Latitud;
            _actualizar.IdOrden = select.IdOrden;
            _actualizar.Estado = select.Estado;
            _actualizar.NombreCliente = $"{select.Nombre} {select.Apellido}";
            await ProductosPagados();
        }
        return null;
    }
    async Task UpdateEstate()
    {
        try
        {

            string jsonString = JsonConvert.SerializeObject(_actualizar);
            Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Actualizar_Pedidos");
            WebClient client = new WebClient();
            var data = await client.UploadStringTaskAsync(url, jsonString);
            Editable = JsonConvert.DeserializeObject(data);
            if (Editable != null)
            {
                await LoadPedidos();
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
            await JSRuntime.InvokeVoidAsync("Confirmar", "success", "¡Exito!", "Tracking actualizado!");
        }
        else
        {
            await JSRuntime.InvokeVoidAsync("Confirmar", "error", "Vaya!", "Ocurrio un error...");
        }

    }
    async Task ProductosPagados()
    {
        try
        {
            string MyUrl = "https://super-mini-market.herokuapp.com/api/Detalles_Carrito_Producto_Pagado/" + pedidos.IdUsuario;
            Uri url = new Uri(MyUrl);
            WebClient client = new WebClient();
            var data = await client.DownloadStringTaskAsync(url);
            Productos_pagos = JsonConvert.DeserializeObject(data);
        }
        catch (Exception)
        {

            throw;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Index> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.FinalAmadis.Pages.AdminPages.AdminIndex
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "name", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
