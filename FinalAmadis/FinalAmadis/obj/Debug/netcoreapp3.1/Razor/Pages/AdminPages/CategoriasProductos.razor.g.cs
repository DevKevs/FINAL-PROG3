#pragma checksum "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0334870ce2d957de7f06d364130e4a43bde6c41e"
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
#line 2 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
using FinalAmadis.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Categorias")]
    public partial class CategoriasProductos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-header");
            __builder.AddAttribute(5, "style", "background-color: #fff");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.AddMarkupContent(10, "<div class=\"col d-inline\">\r\n                    <h3>Categorias de productos</h3>\r\n                </div>\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col d-inline");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "title", "Nueva categoria");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                              Clear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "class", "btn btn-success mr-2 d-inline float-right");
            __builder.AddAttribute(18, "data-toggle", "modal");
            __builder.AddAttribute(19, "data-target", "#AgregarProducto");
            __builder.AddMarkupContent(20, "<i class=\"fas fa-plus-square\"></i> Agregar Categoria");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "card-body");
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-12");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "class", "form-control");
            __builder.AddAttribute(36, "type", "text");
            __builder.AddAttribute(37, "placeholder", "Buscar");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                      Buscar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Buscar = __value, Buscar));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "table");
            __builder.AddAttribute(43, "class", "table table-dark table-borderless");
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.AddMarkupContent(45, "<thead>\r\n                        <tr>\r\n                            <th>Categoria</th>\r\n                            <th>Acciones</th>\r\n                        </tr>\r\n                    </thead>\r\n                    ");
            __builder.OpenElement(46, "tbody");
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 35 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                         if (Datos != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                             foreach (var prov in Datos)
                            {
                                if (!IsVisible(prov))
                                    continue;

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "                                ");
            __builder.OpenElement(49, "tr");
            __builder.AddMarkupContent(50, "\r\n                                    ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 42 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                         prov.Nombre_Categoria

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                                    ");
            __builder.OpenElement(54, "td");
            __builder.AddMarkupContent(55, "\r\n                                        ");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "title", "Editar");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                                           async()=> await data(prov)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "class", "btn btn-success mr-2");
            __builder.AddAttribute(60, "data-toggle", "modal");
            __builder.AddAttribute(61, "data-target", "#exampleModal");
            __builder.AddMarkupContent(62, "<i class=\"fas fa-edit\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                                        ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "title", "Eliminar");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                                             async()=> await data(prov)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "data-toggle", "modal");
            __builder.AddAttribute(68, "data-target", "#EliminarProducto");
            __builder.AddAttribute(69, "class", "btn btn-danger");
            __builder.AddMarkupContent(70, "<i class=\"fas fa-trash-alt\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 48 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                             
                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(74, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
#nullable restore
#line 54 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                 if (Datos == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(77, "                    ");
            __builder.AddMarkupContent(78, "<div class=\"d-flex justify-content-center\">\r\n                        <div class=\"spinner-border\" role=\"status\">\r\n                            <span class=\"visually-hidden\"></span>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 61 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n        \r\n        ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "modal fade");
            __builder.AddAttribute(85, "id", "exampleModal");
            __builder.AddAttribute(86, "tabindex", "-1");
            __builder.AddAttribute(87, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(88, "aria-hidden", "true");
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "modal-dialog");
            __builder.AddMarkupContent(92, "\r\n                ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "modal-content");
            __builder.AddMarkupContent(95, "\r\n                    ");
            __builder.AddMarkupContent(96, @"<div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Editar producto</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "modal-body");
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(100);
            __builder.AddAttribute(101, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 76 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                          categoria

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 76 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                                     HandleUpdate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(104, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(105);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(106, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(107);
                __builder2.AddAttribute(108, "id", "name");
                __builder2.AddAttribute(109, "placeholder", "ID");
                __builder2.AddAttribute(110, "class", "form-control");
                __builder2.AddAttribute(111, "readonly", true);
                __builder2.AddAttribute(112, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 78 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                                                                    categoria.IdCategoria

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(113, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => categoria.IdCategoria = __value, categoria.IdCategoria))));
                __builder2.AddAttribute(114, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => categoria.IdCategoria));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\r\n                            <br>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(116);
                __builder2.AddAttribute(117, "id", "name");
                __builder2.AddAttribute(118, "placeholder", "Nombre de la categoria");
                __builder2.AddAttribute(119, "class", "form-control");
                __builder2.AddAttribute(120, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 80 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                                                                                        categoria.Nombre_categoria

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(121, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => categoria.Nombre_categoria = __value, categoria.Nombre_categoria))));
                __builder2.AddAttribute(122, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => categoria.Nombre_categoria));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(123, "\r\n                            ");
                __Blazor.FinalAmadis.Pages.AdminPages.CategoriasProductos.TypeInference.CreateValidationMessage_0(__builder2, 124, 125, 
#nullable restore
#line 81 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                     () => categoria.Nombre_categoria

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(126, "\r\n                            ");
                __builder2.AddMarkupContent(127, @"<div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                <button type=""submit"" class=""btn btn-primary"">Guardar cambios</button>
                            </div>
                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(128, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n\r\n        \r\n        ");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "modal fade");
            __builder.AddAttribute(135, "id", "EliminarProducto");
            __builder.AddAttribute(136, "tabindex", "-1");
            __builder.AddAttribute(137, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(138, "aria-hidden", "true");
            __builder.AddMarkupContent(139, "\r\n            ");
            __builder.OpenElement(140, "div");
            __builder.AddAttribute(141, "class", "modal-dialog");
            __builder.AddMarkupContent(142, "\r\n                ");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "modal-content");
            __builder.AddMarkupContent(145, "\r\n                    ");
            __builder.AddMarkupContent(146, @"<div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Eliminar Categoria</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    ");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "modal-body");
            __builder.AddMarkupContent(149, "\r\n                        ");
            __builder.OpenElement(150, "h3");
            __builder.AddMarkupContent(151, "¿Está seguro de eliminar \"");
            __builder.AddContent(152, 
#nullable restore
#line 103 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                       categoria.Nombre_categoria

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(153, "\"?");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n                    ");
            __builder.OpenElement(156, "div");
            __builder.AddAttribute(157, "class", "modal-footer");
            __builder.AddMarkupContent(158, "\r\n                        ");
            __builder.AddMarkupContent(159, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">No</button>\r\n                        ");
            __builder.OpenElement(160, "button");
            __builder.AddAttribute(161, "type", "button");
            __builder.AddAttribute(162, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 107 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                        HandleDelete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(163, "class", "btn btn-danger");
            __builder.AddAttribute(164, "data-dismiss", "modal");
            __builder.AddContent(165, "Si");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n\r\n        \r\n        ");
            __builder.OpenElement(171, "div");
            __builder.AddAttribute(172, "class", "modal fade");
            __builder.AddAttribute(173, "id", "AgregarProducto");
            __builder.AddAttribute(174, "tabindex", "-1");
            __builder.AddAttribute(175, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(176, "aria-hidden", "true");
            __builder.AddMarkupContent(177, "\r\n            ");
            __builder.OpenElement(178, "div");
            __builder.AddAttribute(179, "class", "modal-dialog");
            __builder.AddMarkupContent(180, "\r\n                ");
            __builder.OpenElement(181, "div");
            __builder.AddAttribute(182, "class", "modal-content");
            __builder.AddMarkupContent(183, "\r\n                    ");
            __builder.AddMarkupContent(184, @"<div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Agregar Categoria</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    ");
            __builder.OpenElement(185, "div");
            __builder.AddAttribute(186, "class", "modal-body");
            __builder.AddMarkupContent(187, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(188);
            __builder.AddAttribute(189, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 124 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                          categoria

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(190, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 124 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                                     HandleValidSubmi

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(191, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(192, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(193);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(194, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(195);
                __builder2.AddAttribute(196, "id", "name");
                __builder2.AddAttribute(197, "placeholder", "Nombre de la categoria");
                __builder2.AddAttribute(198, "class", "form-control");
                __builder2.AddAttribute(199, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 126 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                                                                                        categoria.Nombre_categoria

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(200, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => categoria.Nombre_categoria = __value, categoria.Nombre_categoria))));
                __builder2.AddAttribute(201, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => categoria.Nombre_categoria));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(202, "\r\n                            ");
                __Blazor.FinalAmadis.Pages.AdminPages.CategoriasProductos.TypeInference.CreateValidationMessage_1(__builder2, 203, 204, 
#nullable restore
#line 127 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                     () => categoria.Nombre_categoria

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(205, "\r\n                            ");
                __builder2.AddMarkupContent(206, @"<div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                <button type=""submit"" class=""btn btn-primary"">Guardar categoria</button>
                            </div>
                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(207, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(208, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(209, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(210, "\r\n        ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 139 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
               
            public dynamic Datos { get; set; }
            public dynamic Editable { get; set; }
            RootCategoria categoria = new RootCategoria();
            string jsonString;
            Api consume = new Api();
            public string Buscar { get; set; }

            protected override async Task OnInitializedAsync()
            {
                try
                {
                    Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Mostrar_Todas_Categoria");
                    WebClient client = new WebClient();
                    var data = await client.DownloadStringTaskAsync(url);
                    Datos = JsonConvert.DeserializeObject(data);

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
                    Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Mostrar_Todas_Categoria");
                    WebClient client = new WebClient();
                    var data = await client.DownloadStringTaskAsync(url);
                    Datos = JsonConvert.DeserializeObject(data);
                }
                catch (Exception)
                {

                    throw;
                }

            }
            private async Task HandleValidSubmi()
            {
                try
                {
                    jsonString = JsonConvert.SerializeObject(categoria);
                    Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Registro_Categorias");
                    WebClient client = new WebClient();
                    var data = await client.UploadStringTaskAsync(url, jsonString);
                    Editable = JsonConvert.DeserializeObject(data);
                    if (Editable != null)
                    {
                        Datos = null;
                        await Reload();
                        categoria = new RootCategoria();
                        Mensajes();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
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
            public async Task<dynamic> data(dynamic select)
            {

                await Task.Delay(10);
                if (select != null)
                {
                    categoria.IdCategoria = select.IdCategoria;
                    categoria.Nombre_categoria = select.Nombre_Categoria;
                }
                return null;
            }
            private async Task HandleUpdate()
            {
                try
                {
                    jsonString = JsonConvert.SerializeObject(categoria);
                    Editable = consume.Post("https://super-mini-market.herokuapp.com/api/Actualizar_Categoria/" + categoria.IdCategoria, jsonString);
                    if (Editable != null)
                    {
                        Datos = null;
                        await Reload();
                        Mensajes();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            private async Task HandleDelete()
            {
                try
                {
                    string url = "https://super-mini-market.herokuapp.com/api/Borrar_Categoria/" + categoria.IdCategoria;
                    Editable = consume.Get(url);
                    if (Editable != null)
                    {
                        Datos = null;
                        await Reload();
                        categoria = new RootCategoria();
                        Mensajes();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            public bool IsVisible(dynamic cate)
            {
                if (string.IsNullOrEmpty(Buscar))
                    return true;
                if (cate.Nombre_Categoria.ToString().Contains(Buscar, StringComparison.OrdinalIgnoreCase))
                    return true;
                return false;
            }
            void Clear()
            {
                categoria = new RootCategoria();
            }
        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Index> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.FinalAmadis.Pages.AdminPages.CategoriasProductos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
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
