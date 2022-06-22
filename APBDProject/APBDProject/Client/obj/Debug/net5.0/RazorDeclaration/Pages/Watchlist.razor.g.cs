// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace APBDProject.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\_Imports.razor"
using APBDProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\_Imports.razor"
using APBDProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\_Imports.razor"
using APBDProject.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/watchlist")]
    public partial class Watchlist : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
       
    private string user;
    private TickerInfo[] tickers;
    private TickerInfo selectedTicker;

    private List<Stock> Data = new List<Stock>();

    protected override async Task OnInitializedAsync()
    {

        try
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            user = authState.User.Identity.Name;
            tickers = await Http.GetFromJsonAsync<TickerInfo[]>($"/watchlist/{user}");
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }
    private async Task RemoveFromWatchlist(TickerInfo ticker)
    {
        var response = await Http.PostAsJsonAsync($"/watchlist/delete/{user}", ticker);

        tickers = await Http.GetFromJsonAsync<TickerInfo[]>($"/watchlist/{user}");
    }
    private async Task GoToDetails(string ticker)
    {
        selectedTicker = await Http.GetFromJsonAsync<TickerInfo>($"/tickers/info/{ticker}");


        Stock[] data = await Http.GetFromJsonAsync<Stock[]>($"/tickers/ohlc/{ticker}");

        Data = new List<Stock>();

        Data.AddRange(data);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
