#pragma checksum "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Components\ChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14fd3fdc0e0de56112154a2cf3b8e3bf2621e084"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\_Imports.razor"
using Confluent.Kafka;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class ChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "panel panel-default");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "panel-handing");
            __builder.AddContent(5, 
#nullable restore
#line 3 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Components\ChildComponent.razor"
                                Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "panel-body");
            __builder.AddContent(10, 
#nullable restore
#line 4 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Components\ChildComponent.razor"
                             ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    <button class=\"btn btn-primary\" @OnClick=\"OnClick\"></button>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Components\ChildComponent.razor"
       
    [Parameter]
    public string Title { get; set; }
    [Parameter]
    public RenderFragment ChildContent { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
