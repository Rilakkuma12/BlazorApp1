#pragma checksum "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Pages\SendKafka.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b861b15b9d209fa5c755ef4c81430c85ff9bf7a"
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
#line 3 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Pages\SendKafka.razor"
using BlazorApp1.PageModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sendkafka")]
    public partial class SendKafka : SendKafkaModel
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>SendKafka</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "name", "message");
            __builder.AddAttribute(8, "placeholder", "在此处填入需要发送的kafka消息");
            __builder.AddAttribute(9, "style", "height: 50px;width: 300px;");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Pages\SendKafka.razor"
                                                  message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => message = __value, message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "select");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Pages\SendKafka.razor"
                       topic

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => topic = __value, topic));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 14 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Pages\SendKafka.razor"
             foreach (var topic in topics)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                ");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", 
#nullable restore
#line 16 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Pages\SendKafka.razor"
                               topic

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, 
#nullable restore
#line 16 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Pages\SendKafka.razor"
                                      topic

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 17 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Pages\SendKafka.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "button");
            __builder.AddAttribute(32, "name", "send");
            __builder.AddAttribute(33, "value", "发送");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Pages\SendKafka.razor"
                                                              SendMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "class", "btn-dark");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591