#pragma checksum "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "544cb1fcf5230e04b51a9a76d42a90e92386b794"
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
            __builder.AddMarkupContent(0, "<h3 id=\"welcome\" b-582nlkx2yw>Your watchlist:</h3>");
#nullable restore
#line 11 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
 if (tickers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p b-582nlkx2yw><em b-582nlkx2yw>Loading...</em></p>");
#nullable restore
#line 14 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
}
else if (tickers.Length == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div b-582nlkx2yw>Looks like your watchlist is empty. Go to dashboard and select the ones that you want to see in your watchlist.</div>");
#nullable restore
#line 18 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.APBDProject.Client.Pages.Watchlist.TypeInference.CreateSfGrid_0(__builder, 3, 4, 
#nullable restore
#line 21 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                         tickers

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 21 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                                               true

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 21 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                                                                   true

#line default
#line hidden
#nullable disable
            , 7, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(8);
                __builder2.AddAttribute(9, "PageSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                                    5

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(13);
                    __builder3.AddAttribute(14, "Field", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                               nameof(TickerInfo.ticker)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "HeaderText", "Ticker");
                    __builder3.AddAttribute(16, "TextAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 24 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                                                                                        TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(19);
                    __builder3.AddAttribute(20, "Field", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                               nameof(TickerInfo.name)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "HeaderText", "Name");
                    __builder3.AddAttribute(22, "TextAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 25 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                                                                                    TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(25);
                    __builder3.AddAttribute(26, "Field", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                               nameof(TickerInfo.market)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "HeaderText", "Market");
                    __builder3.AddAttribute(28, "TextAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 26 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                                                                                        TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(31);
                    __builder3.AddAttribute(32, "Field", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                               nameof(TickerInfo.locale)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "HeaderText", "Locale");
                    __builder3.AddAttribute(34, "TextAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 27 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                                                                                        TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(37);
                    __builder3.AddAttribute(38, "HeaderText", "Remove from watchlist");
                    __builder3.AddAttribute(39, "Width", "50");
                    __builder3.AddAttribute(40, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
#nullable restore
#line 30 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                      
                        var ticker = (context as TickerInfo);

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(41, "SfButton");
                        __builder4.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                                              (args) => RemoveFromWatchlist(ticker)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(43, "CssClass", "e-primary");
                        __builder4.AddAttribute(44, "b-582nlkx2yw");
                        __builder4.AddContent(45, "Remove from watchlist");
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(47);
                    __builder3.AddAttribute(48, "Width", "50");
                    __builder3.AddAttribute(49, "HeaderText", "See details");
                    __builder3.AddAttribute(50, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
#nullable restore
#line 39 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                      
                        var ticker = (context as TickerInfo);

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(51, "SfButton");
                        __builder4.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                                              (args) => GoToDetails(ticker.ticker)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(53, "CssClass", "e-danger");
                        __builder4.AddAttribute(54, "b-582nlkx2yw");
                        __builder4.AddContent(55, "See details");
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 48 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
    if (selectedTicker != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "h3");
            __builder.AddAttribute(57, "b-582nlkx2yw");
#nullable restore
#line 50 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
__builder.AddContent(58, selectedTicker.ticker);

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, " Details:");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Navigations.SfTab>(61);
            __builder.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Navigations.TabItems>(63);
                __builder2.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(65);
                    __builder3.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(67);
                        __builder4.AddAttribute(68, "Text", "Company information");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(69, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(70, "div");
                        __builder4.AddAttribute(71, "b-582nlkx2yw");
                        __builder4.OpenElement(72, "p");
                        __builder4.AddAttribute(73, "b-582nlkx2yw");
                        __builder4.OpenElement(74, "b");
                        __builder4.AddAttribute(75, "b-582nlkx2yw");
#nullable restore
#line 59 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
__builder4.AddContent(76, selectedTicker.ticker);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(77, "\r\n                            ");
                        __builder4.OpenElement(78, "p");
                        __builder4.AddAttribute(79, "b-582nlkx2yw");
                        __builder4.OpenElement(80, "b");
                        __builder4.AddAttribute(81, "b-582nlkx2yw");
#nullable restore
#line 60 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
__builder4.AddContent(82, selectedTicker.name);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(83, "\r\n                            ");
                        __builder4.OpenElement(84, "p");
                        __builder4.AddAttribute(85, "b-582nlkx2yw");
                        __builder4.OpenElement(86, "a");
                        __builder4.AddAttribute(87, "href", 
#nullable restore
#line 61 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                                         selectedTicker.homepage_url

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(88, "b-582nlkx2yw");
                        __builder4.OpenElement(89, "b");
                        __builder4.AddAttribute(90, "b-582nlkx2yw");
#nullable restore
#line 61 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
__builder4.AddContent(91, selectedTicker.homepage_url);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(92, "\r\n                            ");
                        __builder4.OpenElement(93, "p");
                        __builder4.AddAttribute(94, "b-582nlkx2yw");
#nullable restore
#line 62 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
__builder4.AddContent(95, selectedTicker.description);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(97);
                    __builder3.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(99);
                        __builder4.AddAttribute(100, "Text", "OHLC Chart");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(101, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(102, "div");
                        __builder4.AddAttribute(103, "b-582nlkx2yw");
                        __builder4.OpenComponent<Syncfusion.Blazor.Charts.SfStockChart>(104);
                        __builder4.AddAttribute(105, "Title", "OHCL");
                        __builder4.AddAttribute(106, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Syncfusion.Blazor.Charts.StockChartSeriesCollection>(107);
                            __builder5.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Syncfusion.Blazor.Charts.StockChartSeries>(109);
                                __builder6.AddAttribute(110, "DataSource", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 74 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                                                                   Data

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(111, "Type", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 74 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
                                                                               ChartSeriesType.Candle

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(112, "XName", "Time");
                                __builder6.AddAttribute(113, "High", "h");
                                __builder6.AddAttribute(114, "Low", "h");
                                __builder6.AddAttribute(115, "Open", "o");
                                __builder6.AddAttribute(116, "Close", "c");
                                __builder6.AddAttribute(117, "Volume", "v");
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 82 "C:\Users\User\APBD\Projekt\APBDProject\APBDProject\Client\Pages\Watchlist.razor"
    }
}

#line default
#line hidden
#nullable disable
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
namespace __Blazor.APBDProject.Client.Pages.Watchlist
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowPaging", __arg1);
        __builder.AddAttribute(__seq2, "AllowSorting", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
