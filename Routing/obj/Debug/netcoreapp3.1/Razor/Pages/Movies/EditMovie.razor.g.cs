#pragma checksum "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\EditMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3765173fd9267ef6d4b0ba0a358157529d27a3a"
// <auto-generated/>
#pragma warning disable 1591
namespace Routing.Pages.Movies
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/edit/{MovieId:int}")]
    public partial class EditMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Movie</h3>\r\n");
#nullable restore
#line 4 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\EditMovie.razor"
 if (Movie != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<Routing.Pages.Movies.MovieForm>(2);
            __builder.AddAttribute(3, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Routing.Entities.Movie>(
#nullable restore
#line 6 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\EditMovie.razor"
                       Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 6 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\EditMovie.razor"
                                             Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "NotSelectedGenres", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Routing.Entities.Genre>>(
#nullable restore
#line 6 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\EditMovie.razor"
                                                                      NotSelectedGenres

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "SelectedGenres", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Routing.Entities.Genre>>(
#nullable restore
#line 7 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\EditMovie.razor"
                               SelectedGenres

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 9 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\EditMovie.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\EditMovie.razor"
       
    private Movie Movie;
    [Parameter] public int MovieId { get; set; }


    private List<Genre> NotSelectedGenres = new List<Genre>()
    {
        
        new Genre(){Id=2, Name = "Comedy"},
        new Genre(){Id=3, Name = "Drama" }
    };

    private List<Genre> SelectedGenres = new List<Genre>()
    {
        new Genre(){Id=1, Name = "Action"}
    };

    protected override void OnInitialized()
    {
        base.OnInitialized();
        Movie = new Movie() { Id=MovieId, Title = "My Movie" };
    }
    private void Edit()
    {
        Console.WriteLine("editin the movie..");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
