#pragma checksum "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40f8a1b04c099a29a9aaccd04d0d345e03c8b5e6"
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
#line 2 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
using Front_GroceryToDo.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
using Front_GroceryToDo.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GroceryList")]
    public partial class GroceryList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>GroceryList</h3>\r\n<hr>");
#nullable restore
#line 9 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
 if (record == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "em");
            __builder.AddContent(3, 
#nullable restore
#line 17 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
         record.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<em>Uncompleted</em>\r\n    ");
            __builder.OpenComponent<Front_GroceryToDo.Pages.ListRendering>(6);
            __builder.AddAttribute(7, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Front_GroceryToDo.Models.Item>>(
#nullable restore
#line 19 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                           uncompletedItems

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "GroceryListInstance", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Front_GroceryToDo.Pages.GroceryList>(
#nullable restore
#line 19 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                                                                   this

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.AddMarkupContent(10, "<em>Completed</em>\r\n    ");
            __builder.OpenComponent<Front_GroceryToDo.Pages.ListRendering>(11);
            __builder.AddAttribute(12, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Front_GroceryToDo.Models.Item>>(
#nullable restore
#line 21 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                           completedItems

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "GroceryListInstance", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Front_GroceryToDo.Pages.GroceryList>(
#nullable restore
#line 21 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                                                                 this

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                                              Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(18, "\r\n        Add\r\n    ");
            __builder.CloseElement();
#nullable restore
#line 25 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
       
    private Record record;
    private List<Item> completedItems;
    private List<Item> uncompletedItems;

    protected override async Task OnInitializedAsync()
    {
        record = await RecordsService.GetRecordByIdAsync(9999);
        completedItems = new List<Item>();
        uncompletedItems = new List<Item>();
        foreach (var item in record.Items)
        {
            if (item.IsCompleted)
            {
                completedItems.Add(item);
            }
            else
            {
                uncompletedItems.Add(item);
            }
        }
    }

    private void Add()
    {
        NavManager.NavigateTo("AddItem");
    }

    public void test()
    {
        Console.WriteLine("test");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecordsService RecordsService { get; set; }
    }
}
#pragma warning restore 1591
