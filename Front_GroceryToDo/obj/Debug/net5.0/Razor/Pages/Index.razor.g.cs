#pragma checksum "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b6c336c1dd578661380701bf43a215ae9b9c87a"
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
#line 2 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\Index.razor"
using Front_GroceryToDo.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-body");
            __builder.AddMarkupContent(4, "<p><b>Input list ID:</b></p>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "number");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\Index.razor"
                                    id

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => id = __value, id, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\Index.razor"
                          EnteredIdButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Go to list");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "em");
            __builder.AddAttribute(15, "style", "color: red");
            __builder.AddContent(16, 
#nullable restore
#line 14 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\Index.razor"
                                errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        <br>\r\n        <br>\r\n        Or, generate a new list:\r\n        ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\Index.razor"
                          GenerateButtonPressed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Generate a new list");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\Index.razor"
      

    private int? id;
    private string errorMessage;

    protected override void OnInitialized()
    {
        int cachedId = UserService.GetCachedId();
        if (cachedId != 0)
        {
            id = cachedId;
        }
    }

    private async Task EnteredIdButtonClicked()
    {
        try
        {
            if (id >= 1000 && id <= 9999)
            {
                await RecordsService.GetRecordByIdAsync((int) id);
                errorMessage = "";
                NavManager.NavigateTo("/GroceryList");
            }
            else
            {
                errorMessage = "Value should be between 1000 and 9999";
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            errorMessage = "The list with the entered ID does not exist, please enter another ID or generate a new list.";
        }
    }

    private async Task GenerateButtonPressed()
    {
        try
        {
            await RecordsService.CreateRecordAsync();
            errorMessage = "";
            NavManager.NavigateTo("/GroceryList");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            NavManager.NavigateTo("/Error");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecordsService RecordsService { get; set; }
    }
}
#pragma warning restore 1591
