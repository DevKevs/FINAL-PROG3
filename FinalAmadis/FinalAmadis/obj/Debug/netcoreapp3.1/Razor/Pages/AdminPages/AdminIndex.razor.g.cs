#pragma checksum "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4eb73e6722b12c806a28883414883c3d248ac31"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class AdminIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 12 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
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
#line 32 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                             if (Pedidos != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
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
#line 37 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                             prov.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, " ");
            __builder.AddContent(26, 
#nullable restore
#line 37 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
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
#line 38 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
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
#line 39 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
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
#line 41 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
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
#line 42 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
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
#line 45 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
                                 
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
#line 58 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
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
#line 73 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
   
    
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
 if (Datos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "    ");
            __builder.AddMarkupContent(79, "<div class=\"d-flex justify-content-center\">\r\n        <div class=\"spinner-border\" role=\"status\">\r\n            <span class=\"visually-hidden\"></span>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 83 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\gt\Desktop\Final Amadís\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\AdminIndex.razor"
      

    public dynamic Datos { get; set; }
    public dynamic Pedidos { get; set; }
    public dynamic Editable { get; set; }
    string jsonString;
    Pago pedidos = new Pago();
    Api consume = new Api();
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
    public async Task<dynamic> data(dynamic select)
    {

        await Task.Delay(10);
        if (select != null)
        {
            pedidos.IdUsuario = select.IdUsuario;
            pedidos.Estado = select.Estado;
            pedidos.Longitud = select.Longitud;
            pedidos.Latitud = select.Latitud;
        }
        return null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Index> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
