#pragma checksum "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd7cd3505a6a8a809f841a74cd172ca3e06620bd"
// <auto-generated/>
#pragma warning disable 1591
namespace Routing.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Routing.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Routing.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Routing.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Routing.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    public partial class CustomTypeahead<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "blazored-typeahead");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "blazored-typeahead__controls");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "blazored-typeahead__input");
            __builder.AddAttribute(9, "autocomplete", "off");
            __builder.AddAttribute(10, "placeholder", 
#nullable restore
#line 10 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
                             Placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
                          ShowSuggestions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
                            onfocusout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
                             SearchText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchText = __value, SearchText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 16 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
     if (IsSearching)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "        ");
            __builder.AddMarkupContent(18, "<div class=\"blazored-typeahead__results\">\r\n            <div class=\"blazored-typeahead__result\">\r\n                <span>Loading..</span>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 23 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
    }
    else if (ShouldShowSuggestions())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "blazored-typeahead__results");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 27 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
             foreach (var item in Suggestions)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "blazored-typeahead__result");
            __builder.AddAttribute(26, "tabindex", "0");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
                                              () => SelectSuggestion(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
                                    OnmouseoverSuggestion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
                                                                        OnmouseoutSuggestion

#line default
#line hidden
#nullable disable
            ));
            __builder.SetKey(
#nullable restore
#line 29 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
                           item

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.AddContent(31, 
#nullable restore
#line 32 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
                     ResultTemplate(item)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 34 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 36 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
    }
    else if (ShowNotFound())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "blazored-typeahead__results");
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 40 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
             if (NotFoundTemplate != null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "blazored-typeahead__notfound");
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.AddContent(44, 
#nullable restore
#line 43 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
                     NotFoundTemplate

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 45 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                ");
            __builder.AddMarkupContent(48, "<div class=\"blazored-typeahead__notfound\">\r\n                    No Results Found\r\n                </div>\r\n");
#nullable restore
#line 51 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 53 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\CustomTypeahead.razor"
       
    [Parameter] public string Placeholder { get; set; }
    [Parameter] public int MinimumLength { get; set; } = 3;
    [Parameter] public int Debounce { get; set; } = 300;
    [Parameter] public Func<string, Task<IEnumerable<TItem>>> SearchMethod { get; set; }
    [Parameter] public RenderFragment<TItem> ResultTemplate { get; set; }
    [Parameter] public RenderFragment NotFoundTemplate { get; set; }
    [Parameter] public EventCallback <TItem> ValueChanged { get; set; }

    private bool IsSearching = false;
    private bool isShowingSuggestions = false;
    private string _searchText = string.Empty;
    private Timer _debounceTimer;
    protected TItem[] Suggestions { get; set; } = new TItem[0];

    protected override void OnInitialized()
    {
        _debounceTimer = new Timer();
        _debounceTimer.Interval = Debounce;
        _debounceTimer.AutoReset = false;
        _debounceTimer.Elapsed += Search;
        base.OnInitialized();
    }
    private bool ShowNotFound()
    {
        return !Suggestions.Any() && isShowingSuggestions;
    }


    private async Task SelectSuggestion (TItem item)
    {
        SearchText = "";
        await ValueChanged.InvokeAsync(item);
    }
    protected async void Search ( Object source, ElapsedEventArgs e)
    {
        IsSearching = true;
        isShowingSuggestions = false;
        await InvokeAsync(StateHasChanged);

        Suggestions = (await SearchMethod.Invoke(_searchText)).ToArray();
        IsSearching = false;
        isShowingSuggestions = true;
        await InvokeAsync(StateHasChanged);
    }


    private string SearchText
    {
        get => _searchText;
        set
        {
            _searchText = value;
            if (value.Length == 0)
            {
                isShowingSuggestions = false;
                _debounceTimer.Stop();
                Suggestions = new TItem[0];
            }
            else if (value.Length >= MinimumLength)
            {
                _debounceTimer.Stop();
                _debounceTimer.Start();
            }
        }
    }

    private bool ShouldShowSuggestions()
    {
        return isShowingSuggestions && Suggestions.Any();

    }

    private void ShowSuggestions()
    {
        if (Suggestions.Any())
        {
            isShowingSuggestions = true;
        }
    }
    private void onfocusout()
    {
        if (!isMouseInSuggestion)
        {
            isShowingSuggestions = false;
        }
    }

    bool isMouseInSuggestion = false;

    private void OnmouseoverSuggestion()
    {
        isMouseInSuggestion=true;
    }

    private void OnmouseoutSuggestion()
    {
        isMouseInSuggestion=true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
