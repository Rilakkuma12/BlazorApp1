#pragma checksum "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Pages\InputFile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbea574f863852d96a094e7eb17e0a2f212af3b4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
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
#nullable restore
#line 2 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Pages\InputFile.razor"
using BlazorApp1.PageModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inputfile")]
    public partial class InputFile : InputFileModel
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Component</h3>\r\n");
            __builder.AddMarkupContent(1, "<div>\r\n    <input type=\"file\" name=\"name\" value id=\"inputfile\">\r\n</div>\r\n");
            __builder.AddMarkupContent(2, "<div>\r\n    <button @onclick=\"Upload\">上传</button>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591