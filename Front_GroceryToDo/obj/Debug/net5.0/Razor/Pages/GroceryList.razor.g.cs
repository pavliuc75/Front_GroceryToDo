#pragma checksum "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f56e995c9f37e191783225b10a6a7e3b004d1238"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-body");
#nullable restore
#line 11 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
         if (record == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p>");
#nullable restore
#line 16 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "p");
            __builder.OpenElement(6, "b");
            __builder.AddMarkupContent(7, "\r\n                    List Unique ID: ");
            __builder.OpenElement(8, "em");
            __builder.AddContent(9, 
#nullable restore
#line 21 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                                         record.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "span");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                                          CopyToClipboard

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Copy");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.AddMarkupContent(16, "<p><a href=\"/\">Switch list</a></p>\r\n            <hr>\r\n            ");
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, "Description: ");
            __builder.OpenElement(19, "em");
            __builder.AddContent(20, 
#nullable restore
#line 31 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                                 record.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            <hr>\r\n            ");
            __builder.AddMarkupContent(22, "<em>Uncompleted</em>\r\n            ");
            __builder.OpenComponent<Front_GroceryToDo.Pages.ListRendering>(23);
            __builder.AddAttribute(24, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Front_GroceryToDo.Models.Item>>(
#nullable restore
#line 34 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                                   uncompletedItems

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "ButtonName", "Complete");
            __builder.AddAttribute(26, "GroceryListInstance", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Front_GroceryToDo.Pages.GroceryList>(
#nullable restore
#line 34 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                                                                                                 this

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(28, "<em>Completed</em>\r\n            ");
            __builder.OpenElement(29, "span");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", 
#nullable restore
#line 38 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                                CompletedTableIcon

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                                                              ToggleMenu2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", 
#nullable restore
#line 40 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                         CompletedTableCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.OpenComponent<Front_GroceryToDo.Pages.ListRendering>(36);
            __builder.AddAttribute(37, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Front_GroceryToDo.Models.Item>>(
#nullable restore
#line 41 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                                       completedItems

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "ButtonName", "Incomplete");
            __builder.AddAttribute(39, "GroceryListInstance", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Front_GroceryToDo.Pages.GroceryList>(
#nullable restore
#line 41 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                                                                                                     this

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            <hr>\r\n            ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                              Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(43, "\r\n                Add\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            <br>\r\n            <br>\r\n            ");
            __builder.OpenElement(45, "div");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                                  ToggleMenu1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(48, "\r\n                    Settings\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", 
#nullable restore
#line 53 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(52, "div");
            __builder.OpenElement(53, "ul");
            __builder.OpenElement(54, "li");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                                                  WipeButtonPressed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, "Wipe all data");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                            ");
            __builder.OpenElement(59, "li");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
                                                  ChangeDescriptionButtonPressed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "Change list description");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 66 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\GroceryList.razor"
       
    public Record record;
    private List<Item> completedItems;
    private List<Item> uncompletedItems;

    bool collapseMenu;
    bool collapseCompletedTable = true;
    string NavMenuCssClass => collapseMenu ? "collapse" : null;
    string CompletedTableCssClass => collapseCompletedTable ? "collapse" : null;
    string CompletedTableIcon = "oi oi-arrow-bottom";

    void ToggleMenu1()
    {
        collapseMenu = !collapseMenu;
    }

    void ToggleMenu2()
    {
        collapseCompletedTable = !collapseCompletedTable;
        if (CompletedTableIcon.Equals("oi oi-arrow-bottom"))
        {
            CompletedTableIcon = "oi oi-arrow-top";
        }
        else
        {
            CompletedTableIcon = "oi oi-arrow-bottom";
        }
    }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            record = await RecordsService.GetRecordByIdAsync(UserService.GetCachedId());
            completedItems = new List<Item>();
            uncompletedItems = new List<Item>();
            collapseMenu = true;
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
        catch (Exception e)
        {
            Console.WriteLine(e);
            NavManager.NavigateTo("/Error");
        }
    }

    private void Add()
    {
        NavManager.NavigateTo("AddItem");
    }

    private async Task WipeButtonPressed()
    {
        try
        {
            bool result = await RecordsService.WipeRecordAsync();
            if (result)
            {
                await Reload();
            }
            else
            {
                NavManager.NavigateTo("/Error");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            NavManager.NavigateTo("/Error");
        }
    }

    public async Task Reload()
    {
    //record = await RecordsService.GetRecordByIdAsync(9999);
        await OnInitializedAsync();
        StateHasChanged();
    }

    private void ChangeDescriptionButtonPressed()
    {
        NavManager.NavigateTo("/ChangeRecordDescription");
    }

    private async Task CopyToClipboard()
    {
        try
        {
            await ClipboardService.WriteTextAsync(record.Id.ToString());
        }
        catch
        {
            Console.WriteLine("Cannot write text to clipboard");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClipboardService ClipboardService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecordsService RecordsService { get; set; }
    }
}
#pragma warning restore 1591
