// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "E:\Projects\GroceryAppBlazor\Front_GroceryToDo\Front_GroceryToDo\Pages\Index.razor"
      

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
