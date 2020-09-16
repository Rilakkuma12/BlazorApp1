#pragma checksum "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Components\DragDropContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b76d4670f37c8cd6b56b4c3eaa5daf6e114f701b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 1 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Components\DragDropContainer.razor"
using BlazorApp1.Service;

#line default
#line hidden
#nullable disable
    public partial class DragDropContainer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "D:\python_course\BlazorApp1\BlazorApp1\BlazorApp1\Components\DragDropContainer.razor"
       
    /// <summary>
    /// The refresh handler from the parent
    /// </summary>
    [Parameter]
    public Action RefreshHandler { get; set; }

    [Parameter]
    public int Index { get; set; }

    string _highlightDropTargetStyle = null;

    void OnItemDragStart(DragEventArgs e, DragItem dragItem)
    {
        DragDropHelper.Item = dragItem;
    }

    void OnContainerDragEnter(DragEventArgs e)
    {
        _highlightDropTargetStyle = "border:5px dashed salmon !important";
    }

    void OnContainerDragLeave(DragEventArgs e)
    {
        _highlightDropTargetStyle = null;
    }

    void OnContainerDrop(DragEventArgs e, int newIndex)
    {
        _highlightDropTargetStyle = null;
        DragDropHelper.Item.Index = newIndex;
        RefreshHandler();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DragDropHelper DragDropHelper { get; set; }
    }
}
#pragma warning restore 1591
