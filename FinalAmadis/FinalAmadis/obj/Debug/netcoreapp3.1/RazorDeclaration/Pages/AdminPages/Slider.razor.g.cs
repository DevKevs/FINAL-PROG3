// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\Slider.razor"
using FinalAmadis.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\Slider.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\Slider.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\Slider.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Slider")]
    public partial class Slider : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 149 "C:\Users\david\Desktop\FINAL-PROG3\FinalAmadis\FinalAmadis\Pages\AdminPages\Slider.razor"
       
    public dynamic Datos { get; set; }
    public dynamic Editable { get; set; }
    string jsonString;
    Api consume = new Api();
    Sliders slides = new Sliders();
    public string Buscar { get; set; }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Mostrar_Todos_Slides");
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
            Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Mostrar_Todos_Slides");
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
            jsonString = JsonConvert.SerializeObject(slides);
            Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Registrar_Slides");
            WebClient client = new WebClient();
            var data = await client.UploadStringTaskAsync(url, jsonString);
            Editable = JsonConvert.DeserializeObject(data);
            if (Editable != null)
            {
                Datos = null;
                await Reload();
                slides = new Sliders();
                Mensajes();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    private async Task HandleUpdate()
    {
        try
        {
            jsonString = JsonConvert.SerializeObject(slides);
            Editable = consume.Post("https://super-mini-market.herokuapp.com/api/Actualizar_Slides/" + slides.IdSlider, jsonString);
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
            string url = "https://super-mini-market.herokuapp.com/api/Borrar_Slides/" + slides.IdSlider;
            Editable = consume.Get(url);
            if (Editable != null)
            {
                Datos = null;
                await Reload();
                slides = new Sliders();
                Mensajes();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public bool IsVisible(dynamic productos)
    {
        if (string.IsNullOrEmpty(Buscar))
            return true;
        if (productos.Titulo.ToString().Contains(Buscar, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }
    public async Task<dynamic> data(dynamic select)
    {

        await Task.Delay(10);
        if (select != null)
        {
            slides.IdSlider = select.IdSlider;
            slides.Titulo = select.Titulo;
            slides.Recurso = select.Recurso;
        }
        return null;
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

    void Clear()
    {
        slides = new Sliders();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Index> Logger { get; set; }
    }
}
#pragma warning restore 1591
