#pragma checksum "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d20671823f7329545ac93343121dc70de375b8a"
// <auto-generated/>
#pragma warning disable 1591
namespace FinalAmadis.Pages.LoginPages
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
#line 3 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor"
using FinalAmadis.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Signup")]
    public partial class Signup : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "center");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-8 card");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddMarkupContent(5, "<div class=\"col-12 row\">\r\n            <p>&nbsp;</p>\r\n        </div>\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-12 row");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<div class=\"col-6\" style=\"border-right:groove\">\r\n                <img src=\"/img/Shopping-rafiki.svg\" width=\"400\">\r\n            </div>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-6");
            __builder.AddAttribute(12, "style", "border-left:thick");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(14);
            __builder.AddAttribute(15, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor"
                                  user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor"
                                                        RegisterUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.AddMarkupContent(21, "<div>\r\n                        <br><br>\r\n                    </div>\r\n                    ");
                __builder2.AddMarkupContent(22, "<div>\r\n                        <h3 style=\"font-weight:bold;\">Fusion Market <br> Registrarse</h3>\r\n                    </div>\r\n                    ");
                __builder2.AddMarkupContent(23, "<div>\r\n                        <br>\r\n                    </div>\r\n                    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-12 row");
                __builder2.AddMarkupContent(26, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "id", "Correo");
                __builder2.AddAttribute(29, "type", "text");
                __builder2.AddAttribute(30, "placeholder", "Nombre");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor"
                                                                                                                  user.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Nombre = __value, user.Nombre))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __Blazor.FinalAmadis.Pages.LoginPages.Signup.TypeInference.CreateValidationMessage_0(__builder2, 36, 37, 
#nullable restore
#line 30 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor"
                                                 () => user.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                    <br>\r\n                    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "col-12 row");
                __builder2.AddMarkupContent(42, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "id", "Correo");
                __builder2.AddAttribute(45, "type", "text");
                __builder2.AddAttribute(46, "placeholder", "Apellido");
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor"
                                                                                                                    user.Apellido

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Apellido = __value, user.Apellido))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Apellido));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __Blazor.FinalAmadis.Pages.LoginPages.Signup.TypeInference.CreateValidationMessage_1(__builder2, 52, 53, 
#nullable restore
#line 35 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor"
                                                 () => user.Apellido

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                    <br>\r\n                    ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-12 row");
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __Blazor.FinalAmadis.Pages.LoginPages.Signup.TypeInference.CreateInputDate_2(__builder2, 59, 60, "Correo", 61, "date", 62, "Fecha nacimiento", 63, "form-control", 64, 
#nullable restore
#line 39 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor"
                                                                                                                            fecha

#line default
#line hidden
#nullable disable
                , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fecha = __value, fecha)), 66, () => fecha);
                __builder2.AddMarkupContent(67, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                    <br>\r\n                    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "col-12 row");
                __builder2.AddMarkupContent(71, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(72);
                __builder2.AddAttribute(73, "id", "Correo");
                __builder2.AddAttribute(74, "type", "email");
                __builder2.AddAttribute(75, "placeholder", "Direccion de correo");
                __builder2.AddAttribute(76, "class", "form-control");
                __builder2.AddAttribute(77, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor"
                                                                                                                                user.Correo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Correo = __value, user.Correo))));
                __builder2.AddAttribute(79, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Correo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n                        ");
                __Blazor.FinalAmadis.Pages.LoginPages.Signup.TypeInference.CreateValidationMessage_3(__builder2, 81, 82, 
#nullable restore
#line 44 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor"
                                                 () => user.Correo

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(83, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                    <br>\r\n                    ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "col-12 row");
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(88);
                __builder2.AddAttribute(89, "id", "Correo");
                __builder2.AddAttribute(90, "type", "password");
                __builder2.AddAttribute(91, "placeholder", "Contraseña");
                __builder2.AddAttribute(92, "class", "form-control");
                __builder2.AddAttribute(93, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor"
                                                                                                                          user.Contraseña

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Contraseña = __value, user.Contraseña))));
                __builder2.AddAttribute(95, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Contraseña));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\r\n                        ");
                __Blazor.FinalAmadis.Pages.LoginPages.Signup.TypeInference.CreateValidationMessage_4(__builder2, 97, 98, 
#nullable restore
#line 49 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor"
                                                 () => user.Contraseña

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(99, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                    <br>\r\n                    ");
                __builder2.AddMarkupContent(101, @"<div class=""col-12 row"">
                        <span class=""col-12""></span>
                        <input type=""submit"" class=""form-control col-6 btn btn-primary"" value=""Registrarse"">
                        <a href=""/"" class=""col-6"">Log in</a>
                    </div>
                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(102, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n        ");
            __builder.AddMarkupContent(105, "<div class=\"col-12 row\">\r\n            <p>&nbsp;</p>\r\n        </div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
            __builder.OpenElement(108, "label");
            __builder.AddContent(109, 
#nullable restore
#line 65 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor"
        user.Fecha_Nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\LoginPages\Signup.razor"
       
    private RegistroUsuario user = new RegistroUsuario();
    string LoginMesssage;
    DateTime fecha;
    public dynamic Editable { get; set; }
    string jsonString;
    private async Task RegisterUser()
    {
        try
        {
            user.Rol = "Cliente";
            user.Fecha_Nacimiento = fecha.ToString("dd/MM/yyyy");
            jsonString = JsonConvert.SerializeObject(user);
            Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Registro_Usuarios");
            WebClient client = new WebClient();
            var data = await client.UploadStringTaskAsync(url, jsonString);
            Editable = JsonConvert.DeserializeObject(data);
            if (Editable != null)
            {
                Mensajes();
                NavigationManager.NavigateTo("/");
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
            await JSRuntime.InvokeVoidAsync("Confirmar", "success", "¡Exito!", "Registro exitoso!");
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.FinalAmadis.Pages.LoginPages.Signup
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
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "type", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "class", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
