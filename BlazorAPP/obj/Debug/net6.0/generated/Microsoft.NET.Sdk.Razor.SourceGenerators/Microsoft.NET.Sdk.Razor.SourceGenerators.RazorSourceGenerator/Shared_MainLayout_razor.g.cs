﻿#pragma checksum "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Shared\MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5b6d13d7d6919fd094dc69fc38fe43eecdbde197623913089544419fa1f90c88"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAPP.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\_Imports.razor"
using BlazorAPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\_Imports.razor"
using BlazorAPP.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "BlazorAPP");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "page");
            __builder.AddAttribute(6, "b-3vyxtnpbq6");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "sidebar");
            __builder.AddAttribute(9, "b-3vyxtnpbq6");
            __builder.OpenComponent<BlazorAPP.Shared.NavMenu>(10);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n    ");
            __builder.OpenElement(12, "main");
            __builder.AddAttribute(13, "b-3vyxtnpbq6");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "top-row px-4 auth");
            __builder.AddAttribute(16, "b-3vyxtnpbq6");
            __builder.OpenComponent<BlazorAPP.Shared.LoginDisplay>(17);
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddMarkupContent(19, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-3vyxtnpbq6>About</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n        ");
            __builder.OpenElement(21, "article");
            __builder.AddAttribute(22, "class", "content px-4");
            __builder.AddAttribute(23, "b-3vyxtnpbq6");
#nullable restore
#line (17,14)-(17,18) 25 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Shared\MainLayout.razor"
__builder.AddContent(24, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591