﻿#pragma checksum "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\DeleteeUser.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ea7071dff755dcaea89e977343e9ea6bebc81f4ec98a6f719ac0837856e827a0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAPP.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/user/delete/{userId:int}")]
    public partial class DeleteeUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Deletee User</h2>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "<h4>Do you want to delete this user?</h4>\r\n    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.OpenElement(6, "tbody");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "<td>First name</td>\r\n                ");
            __builder.OpenElement(9, "td");
#nullable restore
#line (13,22)-(13,36) 25 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\DeleteeUser.razor"
__builder.AddContent(10, user.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "<td>Last name</td>\r\n                ");
            __builder.OpenElement(14, "td");
#nullable restore
#line (17,22)-(17,35) 25 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\DeleteeUser.razor"
__builder.AddContent(15, user.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "<td>id</td>\r\n                ");
            __builder.OpenElement(19, "td");
#nullable restore
#line (21,22)-(21,29) 25 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\DeleteeUser.razor"
__builder.AddContent(20, user.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "submit");
            __builder.AddAttribute(26, "value", "Delete");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\DeleteeUser.razor"
                                                  (async () => await RemoveUser(user.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "btn btn-danger");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "submit");
            __builder.AddAttribute(32, "value", "Cancel");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\DeleteeUser.razor"
                                                  (() => Cancel())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "class", "btn btn-warning");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591