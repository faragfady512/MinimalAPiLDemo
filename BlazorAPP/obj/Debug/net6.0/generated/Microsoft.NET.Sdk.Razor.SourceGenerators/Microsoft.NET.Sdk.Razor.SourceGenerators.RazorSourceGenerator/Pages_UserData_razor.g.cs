﻿#pragma checksum "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "25b95a0825a19ee8bf0022abc1c97d0406fed261d3d59697c334aa5257c368e0"
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
#nullable restore
#line 2 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UserData")]
    public partial class UserData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>User Data</h1>\r\n");
            __builder.AddMarkupContent(1, "<p>Blazor CRUD operation</p>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "<div class=\"col-md-6\"><a href=\'/user/add\' class=\"btn btn-primary\" role=\"button\"><i class=\"fas fa-user-plus\"></i>\r\n            Add User\r\n        </a></div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "input-group col");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "placeholder", "Search user by name");
            __builder.AddAttribute(11, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor"
                                                                    FilterUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor"
                      SearchString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchString = __value, SearchString));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor"
         if (SearchString.Length > 0)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "input-group-append");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn btn-danger");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor"
                                                         ResetSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "<i class=\"fas fa-times\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n<br>");
#nullable restore
#line 32 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor"
 if (userList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "<p><em>Loading...</em></p>");
#nullable restore
#line 35 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table table-striped align-middle table-bordered");
            __builder.AddMarkupContent(24, "<thead class=\"table-success\"><tr><th>ID</th>\r\n                <th>First Name</th>\r\n                <th>LastName</th></tr></thead>\r\n        ");
            __builder.OpenElement(25, "tbody");
#nullable restore
#line 48 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor"
             foreach (var user in userList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "tr");
            __builder.OpenElement(27, "td");
#nullable restore
#line (51,26)-(51,33) 25 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor"
__builder.AddContent(28, user.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
#nullable restore
#line (52,26)-(52,40) 25 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor"
__builder.AddContent(31, user.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
#nullable restore
#line (53,26)-(53,39) 25 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor"
__builder.AddContent(34, user.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", "/user/edit/" + (
#nullable restore
#line 55 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor"
                                             user.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "class", "btn btn-outline-dark");
            __builder.AddAttribute(40, "role", "button");
            __builder.AddMarkupContent(41, "\r\n                            Edit\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "href", "/user/delete/" + (
#nullable restore
#line 58 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor"
                                               user.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "class", "btn btn-outline-danger");
            __builder.AddAttribute(46, "role", "button");
            __builder.AddMarkupContent(47, "\r\n                            Delete\r\n                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "C:\Users\Fady Farag\source\repos\minimalApiDemo\BlazorAPP\Pages\UserData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
