#pragma checksum "C:\Users\shawty\source\repos\BlazorAppEMptyAttTest\BlazorAppEMptyAttTest\Shared\TestComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c411d31dd1cbb8a35a4c2a290d795189b8741aac"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppEMptyAttTest.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\shawty\source\repos\BlazorAppEMptyAttTest\BlazorAppEMptyAttTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shawty\source\repos\BlazorAppEMptyAttTest\BlazorAppEMptyAttTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\shawty\source\repos\BlazorAppEMptyAttTest\BlazorAppEMptyAttTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\shawty\source\repos\BlazorAppEMptyAttTest\BlazorAppEMptyAttTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\shawty\source\repos\BlazorAppEMptyAttTest\BlazorAppEMptyAttTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\shawty\source\repos\BlazorAppEMptyAttTest\BlazorAppEMptyAttTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\shawty\source\repos\BlazorAppEMptyAttTest\BlazorAppEMptyAttTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\shawty\source\repos\BlazorAppEMptyAttTest\BlazorAppEMptyAttTest\_Imports.razor"
using BlazorAppEMptyAttTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\shawty\source\repos\BlazorAppEMptyAttTest\BlazorAppEMptyAttTest\_Imports.razor"
using BlazorAppEMptyAttTest.Shared;

#line default
#line hidden
#nullable disable
    public partial class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "width: 80%; margin: auto; height: 100px; border: 1px solid black;");
            __builder.AddMarkupContent(2, "<p class>This is my test component with an empty class attribute</p>\r\n  ");
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "multiple");
            __builder.OpenElement(5, "option");
            __builder.AddAttribute(6, "value", "1");
            __builder.AddContent(7, "One");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "option");
            __builder.AddAttribute(10, "value", "2");
            __builder.AddContent(11, "Two");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", "3");
            __builder.AddContent(15, "Three");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", "4");
            __builder.AddContent(19, "Four");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
