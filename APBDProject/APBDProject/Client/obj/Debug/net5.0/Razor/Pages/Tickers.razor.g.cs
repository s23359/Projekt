#pragma checksum "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07155e19aae6953db3010dea361eedf68b4322ba"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
using APBDProject.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Dashboard")]
    public partial class Tickers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 id=\"welcome\" b-zxwicpj4kt>Search for tickers</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "b-zxwicpj4kt");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "id", "welcome");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
                                                              (e) => { if(((string)e.Value).Length != 0)@val=(string)e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
                                             val

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => val = __value, val));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(9, "b-zxwicpj4kt");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "<br b-zxwicpj4kt>\r\n");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
                    () => { OnChangeTickers(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-zxwicpj4kt");
            __builder.AddContent(14, "Szukaj");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
 if(val == null || val.Length == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "<p b-zxwicpj4kt><div id=\"welcome\" b-zxwicpj4kt>Use the above input field to find tickers that interest You</div></p>");
#nullable restore
#line 17 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
}
else if (tickers == null)
{
    
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "class", "table");
            __builder.AddAttribute(18, "b-zxwicpj4kt");
            __builder.AddMarkupContent(19, @"<thead b-zxwicpj4kt><tr b-zxwicpj4kt><th b-zxwicpj4kt>Ticker</th>
                <th b-zxwicpj4kt>Name</th>
                <th b-zxwicpj4kt>Market</th>
                <th b-zxwicpj4kt>Locale</th>
                <th b-zxwicpj4kt>Type</th></tr></thead>
        ");
            __builder.OpenElement(20, "tbody");
            __builder.AddAttribute(21, "b-zxwicpj4kt");
#nullable restore
#line 35 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
             foreach (var ticker in tickers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "tr");
            __builder.AddAttribute(23, "id", "data");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
                                          () => { OpenDetails(ticker.ticker); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "b-zxwicpj4kt");
            __builder.OpenElement(26, "td");
            __builder.AddAttribute(27, "b-zxwicpj4kt");
#nullable restore
#line 38 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
__builder.AddContent(28, ticker.ticker);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddAttribute(31, "b-zxwicpj4kt");
#nullable restore
#line 39 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
__builder.AddContent(32, ticker.name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "td");
            __builder.AddAttribute(35, "b-zxwicpj4kt");
#nullable restore
#line 40 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
__builder.AddContent(36, ticker.market);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "td");
            __builder.AddAttribute(39, "b-zxwicpj4kt");
#nullable restore
#line 41 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
__builder.AddContent(40, ticker.locale);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "b-zxwicpj4kt");
#nullable restore
#line 42 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
__builder.AddContent(44, ticker.type);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Tickers.razor"
       
    private List<TickerSearch> tickers;
    private string user;
    private string val;

    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        user = authState.User.Identity.Name;

        try
        {
            tickers = null;
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }

    private async void OnChangeTickers()
    {
        if (val != null && val.Length != 0)
        {
            var json = await Http.GetFromJsonAsync<SearchTickersResponse>($"https://api.polygon.io/v3/reference/tickers?active=true&sort=ticker&order=asc&limit=200&search={val}&apiKey=0YTL0kKbNICyA4p7ptpBGeK4aMGp2IjO");
            tickers = json.results;
        }
    }

    private void OpenDetails(string id)
    {
        navigationManager.NavigateTo($"/tickers/details/{id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591