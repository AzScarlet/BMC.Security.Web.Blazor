#pragma checksum "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4acf04ae5604c1758851acfa0450ae5121a76a8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BMC.Security.Web.Blazor.Pages.Auth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using BMC.Security.Web.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using BMC.Security.Web.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor"
using BMC.Security.Tools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Pages\Auth\Login.razor"
       
    string Email = string.Empty;
    string Password = string.Empty;

    async Task DoLogin()
    {
        string ErrorMsg = string.Empty;
        if (string.IsNullOrEmpty(Email))
        {
            ErrorMsg = "Insert email";
        }
        if (string.IsNullOrEmpty(Password))
        {
            ErrorMsg = "Insert password";
        }
        if (ErrorMsg.Length > 0)
        {
            toastService.ShowError(ErrorMsg);
            return;
        }
        else
        {
            string logUrl = $"/login?paramUsername={encode(Email)}&paramPassword={encode(Password)}";
            await jsRuntime.InvokeAsync<object>("OpenUrl", logUrl);
        }

        return;
    }

    private string encode(string param)
    {
        return HttpUtility.UrlEncode(param);
    }

    protected override async Task OnInitializedAsync()
    {
        var uri = navMgr.ToAbsoluteUri(navMgr.Uri);
        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("result", out var resultString))
        {
            var result = bool.Parse(resultString);
            if (!result)
            {
                //showError = true;
                toastService.ShowWarning("username/password salah atau tidak terdaftar", "Perhatian");
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591