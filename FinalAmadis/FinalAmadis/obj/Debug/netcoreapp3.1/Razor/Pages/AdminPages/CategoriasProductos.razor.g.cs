#pragma checksum "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "077ac084dd6cce85514330034ad637508b6890c5"
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
#line 2 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
using FinalAmadis.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
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
            __builder.AddMarkupContent(3, @"<div class=""card-header"" style=""background-color: #fff"">
            <div class=""row"">
                <div class=""col d-inline"">
                    <h3>Categorias de productos</h3>
                </div>
                <div class=""col d-inline"">
                    <button title=""Nueva categoria"" class=""btn btn-success mr-2 d-inline float-right"" data-toggle=""modal"" data-target=""#AgregarProducto""><i class=""fas fa-plus-square""></i> Agregar Categoria</button>
                </div>
            </div>
        </div>
        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-12");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table table-dark table-borderless");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.AddMarkupContent(13, "<thead>\r\n                        <tr>\r\n                            <th>Categoria</th>\r\n                            <th>Acciones</th>\r\n                        </tr>\r\n                    </thead>\r\n                    ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 30 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                         if (Datos != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                             foreach (var prov in Datos)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                                ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\r\n                                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 35 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                         prov.Nombre_Categoria

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                                    ");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "\r\n                                        ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "title", "Editar");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                                           async()=> await data(prov)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "class", "btn btn-success mr-2");
            __builder.AddAttribute(28, "data-toggle", "modal");
            __builder.AddAttribute(29, "data-target", "#exampleModal");
            __builder.AddMarkupContent(30, "<i class=\"fas fa-edit\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                        ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "title", "Eliminar");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                                             async()=> await data(prov)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "data-toggle", "modal");
            __builder.AddAttribute(36, "data-target", "#EliminarProducto");
            __builder.AddAttribute(37, "class", "btn btn-danger");
            __builder.AddMarkupContent(38, "<i class=\"fas fa-trash-alt\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 41 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                             
                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(42, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 47 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                 if (Datos == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                    ");
            __builder.AddMarkupContent(46, "<div class=\"d-flex justify-content-center\">\r\n                        <div class=\"spinner-border\" role=\"status\">\r\n                            <span class=\"visually-hidden\"></span>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 54 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        \r\n        ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "modal fade");
            __builder.AddAttribute(53, "id", "exampleModal");
            __builder.AddAttribute(54, "tabindex", "-1");
            __builder.AddAttribute(55, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(56, "aria-hidden", "true");
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "modal-dialog");
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "modal-content");
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.AddMarkupContent(64, @"<div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Editar producto</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "modal-body");
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(68);
            __builder.AddAttribute(69, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 69 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                          categoria

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 69 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                                     HandleUpdate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(72, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(73);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(75);
                __builder2.AddAttribute(76, "id", "name");
                __builder2.AddAttribute(77, "placeholder", "ID");
                __builder2.AddAttribute(78, "class", "form-control");
                __builder2.AddAttribute(79, "readonly", true);
                __builder2.AddAttribute(80, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 71 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                                                                    categoria.IdCategoria

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => categoria.IdCategoria = __value, categoria.IdCategoria))));
                __builder2.AddAttribute(82, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => categoria.IdCategoria));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n                            <br>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(84);
                __builder2.AddAttribute(85, "id", "name");
                __builder2.AddAttribute(86, "placeholder", "Nombre de la categoria");
                __builder2.AddAttribute(87, "class", "form-control");
                __builder2.AddAttribute(88, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                                                                                        categoria.Nombre_categoria

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => categoria.Nombre_categoria = __value, categoria.Nombre_categoria))));
                __builder2.AddAttribute(90, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => categoria.Nombre_categoria));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n                            ");
                __Blazor.FinalAmadis.Pages.AdminPages.CategoriasProductos.TypeInference.CreateValidationMessage_0(__builder2, 92, 93, 
#nullable restore
#line 74 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                     () => categoria.Nombre_categoria

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(94, "\r\n                            ");
                __builder2.AddMarkupContent(95, @"<div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                <button type=""submit"" class=""btn btn-primary"">Guardar cambios</button>
                            </div>
                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(96, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n\r\n        \r\n        ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "modal fade");
            __builder.AddAttribute(103, "id", "EliminarProducto");
            __builder.AddAttribute(104, "tabindex", "-1");
            __builder.AddAttribute(105, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(106, "aria-hidden", "true");
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "modal-dialog");
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "modal-content");
            __builder.AddMarkupContent(113, "\r\n                    ");
            __builder.AddMarkupContent(114, @"<div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Eliminar Categoria</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "modal-body");
            __builder.AddMarkupContent(117, "\r\n                        ");
            __builder.OpenElement(118, "h3");
            __builder.AddMarkupContent(119, "¿Está seguro de eliminar \"");
            __builder.AddContent(120, 
#nullable restore
#line 96 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                       categoria.Nombre_categoria

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(121, "\"?");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                    ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "modal-footer");
            __builder.AddMarkupContent(126, "\r\n                        ");
            __builder.AddMarkupContent(127, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">No</button>\r\n                        ");
            __builder.OpenElement(128, "button");
            __builder.AddAttribute(129, "type", "button");
            __builder.AddAttribute(130, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 100 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                        HandleDelete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(131, "class", "btn btn-danger");
            __builder.AddAttribute(132, "data-dismiss", "modal");
            __builder.AddContent(133, "Si");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n\r\n        \r\n        ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "modal fade");
            __builder.AddAttribute(141, "id", "AgregarProducto");
            __builder.AddAttribute(142, "tabindex", "-1");
            __builder.AddAttribute(143, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(144, "aria-hidden", "true");
            __builder.AddMarkupContent(145, "\r\n            ");
            __builder.OpenElement(146, "div");
            __builder.AddAttribute(147, "class", "modal-dialog");
            __builder.AddMarkupContent(148, "\r\n                ");
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "class", "modal-content");
            __builder.AddMarkupContent(151, "\r\n                    ");
            __builder.AddMarkupContent(152, @"<div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Agregar Categoria</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    ");
            __builder.OpenElement(153, "div");
            __builder.AddAttribute(154, "class", "modal-body");
            __builder.AddMarkupContent(155, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(156);
            __builder.AddAttribute(157, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 117 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                          categoria

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(158, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 117 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                                     HandleValidSubmi

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(159, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(160, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(161);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(162, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(163);
                __builder2.AddAttribute(164, "id", "name");
                __builder2.AddAttribute(165, "placeholder", "Nombre de la categoria");
                __builder2.AddAttribute(166, "class", "form-control");
                __builder2.AddAttribute(167, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 119 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                                                                                        categoria.Nombre_categoria

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(168, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => categoria.Nombre_categoria = __value, categoria.Nombre_categoria))));
                __builder2.AddAttribute(169, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => categoria.Nombre_categoria));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(170, "\r\n                            ");
                __Blazor.FinalAmadis.Pages.AdminPages.CategoriasProductos.TypeInference.CreateValidationMessage_1(__builder2, 171, 172, 
#nullable restore
#line 120 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
                                                     () => categoria.Nombre_categoria

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(173, "\r\n                            ");
                __builder2.AddMarkupContent(174, @"<div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                <button type=""submit"" class=""btn btn-primary"">Guardar categoria</button>
                            </div>
                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(175, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n        ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\CategoriasProductos.razor"
               
            public dynamic Datos { get; set; }
            public dynamic Editable { get; set; }
            RootCategoria categoria = new RootCategoria();
            string jsonString;
            Api consume = new Api();
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
