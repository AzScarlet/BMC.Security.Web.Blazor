#pragma checksum "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Shared\EmptyLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91d99217602fa130f9d59944e8be175e18a976f1"
// <auto-generated/>
#pragma warning disable 1591
namespace BMC.Security.Web.Blazor.Shared
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
#line 3 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
#line 2 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Shared\EmptyLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public partial class EmptyLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddContent(0, 
#nullable restore
#line 4 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Shared\EmptyLayout.razor"
 Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(2);
            __builder.AddAttribute(3, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 6 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Shared\EmptyLayout.razor"
                          ToastPosition.BottomRight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "C:\Jobs\KLEIN\BMC.Security.Web.Blazor\BMC.Security.Web.Blazor\Shared\EmptyLayout.razor"
                         10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "SuccessClass", "success-toast-override");
            __builder.AddAttribute(6, "ErrorClass", "fa fa-bug");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
