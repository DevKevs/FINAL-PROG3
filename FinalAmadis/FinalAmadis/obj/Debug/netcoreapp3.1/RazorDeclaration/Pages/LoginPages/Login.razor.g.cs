#pragma checksum "C:\Users\gt\source\repos\FinalAmadis\FinalAmadis\Pages\LoginPages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "532759539b0399003af256539ca579b2d8836e65"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FinalAmadis.Pages.LoginPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gt\source\repos\FinalAmadis\FinalAmadis\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gt\source\repos\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gt\source\repos\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gt\source\repos\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gt\source\repos\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gt\source\repos\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gt\source\repos\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gt\source\repos\FinalAmadis\FinalAmadis\_Imports.razor"
using FinalAmadis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gt\source\repos\FinalAmadis\FinalAmadis\_Imports.razor"
using FinalAmadis.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gt\source\repos\FinalAmadis\FinalAmadis\Pages\LoginPages\Login.razor"
using FinalAmadis.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\gt\source\repos\FinalAmadis\FinalAmadis\Pages\LoginPages\Login.razor"
       
    private Usuario user = new Usuario();

    //Pruebas
    List<Usuario> usuarios = new List<Usuario>();
    string LoginMesssage;
    protected override void OnInitialized()
    {
        usuarios.Add(new Usuario() { Email = "Kevinfeliz@gmail.com", Passw = "1234", Rol = "user" });
        usuarios.Add(new Usuario() { Email = "huascarm@gmail.com", Passw = "12345", Rol = "admin" });
    }

    private void ValidateUser()
    {
        try
        {
            var query = from u in usuarios
                        where u.Email == user.Email & u.Passw == user.Passw
                        select u;
            if (query.Count() == 1)
            {
                Usuario encontrado = query.First();
                if (encontrado.Rol == "admin")
                {
                    NavigationManager.NavigateTo("/admin");
                }
                if (encontrado.Rol == "user")
                {
                    NavigationManager.NavigateTo("/index");
                }
            }
            else
            {
                LoginMesssage = "Datos erroneos...";
            }
        }
        catch (Exception)
        {

            LoginMesssage = "Some bobo en la avenida";
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
