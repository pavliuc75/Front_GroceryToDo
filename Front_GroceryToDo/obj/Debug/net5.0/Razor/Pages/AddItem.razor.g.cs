#pragma checksum "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\AddItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "355a5f60feb8aef720727158008a8937a3216f69"
// <auto-generated/>
#pragma warning disable 1591
namespace Front_GroceryToDo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\_Imports.razor"
using Front_GroceryToDo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\_Imports.razor"
using Front_GroceryToDo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\AddItem.razor"
using Front_GroceryToDo.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddItem")]
    public partial class AddItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddItem</h3>\r\n<hr>\r\n");
            __builder.OpenElement(1, "p");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\AddItem.razor"
                  name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-primary");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\AddItem.razor"
                                          Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(9, "\r\n    Add\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\AddItem.razor"
       

    private string name;

    private void Add()
    {
        NavManager.NavigateTo("GroceryList");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecordsService RecordsService { get; set; }
    }
}
#pragma warning restore 1591