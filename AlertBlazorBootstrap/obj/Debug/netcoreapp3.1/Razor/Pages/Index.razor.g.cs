#pragma checksum "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58a7abed307c68480d2d1c761fbab82612870ddc"
// <auto-generated/>
#pragma warning disable 1591
namespace AlertBlazorBootstrap.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\_Imports.razor"
using AlertBlazorBootstrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\_Imports.razor"
using AlertBlazorBootstrap.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\_Imports.razor"
using AlertBlazorBootstrap.Alert;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\Pages\Index.razor"
using AlertBlazorBootstrap.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<AlertBlazorBootstrap.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<AlertBlazorBootstrap.Alert.SimpleAlert>(4);
            __builder.AddAttribute(5, "TypeCss", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AlertBlazorBootstrap.Data.TypeCss>(
#nullable restore
#line 10 "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\Pages\Index.razor"
                      TypeCss.Dark

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Text", "A simple primary alert—check it out!");
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenComponent<AlertBlazorBootstrap.Alert.CompleteAlert>(8);
            __builder.AddAttribute(9, "Header", "Well done!");
            __builder.AddAttribute(10, "TypeCss", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AlertBlazorBootstrap.Data.TypeCss>(
#nullable restore
#line 11 "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\Pages\Index.razor"
                                            TypeCss.Info

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "Body", "Aww yeah, you successfully read this important alert message. This example text is going to run a bit longer so that you can see how spacing within an alert works with this kind of content.");
            __builder.AddAttribute(12, "Footer", "Whenever you need to, be sure to use margin utilities to keep things nice and tidy.");
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenComponent<AlertBlazorBootstrap.Alert.AlertFragment>(14);
            __builder.AddAttribute(15, "TypeCss", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AlertBlazorBootstrap.Data.TypeCss>(
#nullable restore
#line 15 "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\Pages\Index.razor"
                        TypeCss.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "Body", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.AddMarkupContent(18, "<h4 class=\"alert-heading\">Well done!</h4>\r\n        ");
                __builder2.AddMarkupContent(19, "<p>Aww yeah, you successfully read this important alert message. This example text is going to run a bit longer so that you can see how spacing within an alert works with this kind of content.</p>\r\n        <hr>\r\n        ");
                __builder2.AddMarkupContent(20, "<p class=\"mb-0\">Whenever you need to, be sure to use margin utilities to keep things nice and tidy.</p>\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.OpenComponent<AlertBlazorBootstrap.Alert.AlertFragment>(22);
            __builder.AddAttribute(23, "TypeCss", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AlertBlazorBootstrap.Data.TypeCss>(
#nullable restore
#line 25 "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\Pages\Index.razor"
                        TypeCss.Danger

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "Body", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n        A simple secondary alert with ");
                __builder2.AddMarkupContent(26, "<a href=\"/counter\" class=\"alert-link\">an example link</a>. Give it a click if you like.\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(28, "<style>\r\n    .alert {\r\n        position: relative;\r\n        padding: .75rem 1.25rem;\r\n        margin-bottom: 1rem;\r\n        border: 1px solid transparent;\r\n        border-radius: .25rem\r\n    }\r\n\r\n    .alert-heading {\r\n        color: inherit\r\n    }\r\n\r\n    .alert-link {\r\n        font-weight: 700\r\n    }\r\n\r\n    .alert-dismissible {\r\n        padding-right: 4rem\r\n    }\r\n\r\n        .alert-dismissible\r\n        .close {\r\n            position: absolute;\r\n            top: 0;\r\n            right: 0;\r\n            padding: .75rem 1.25rem;\r\n            color: inherit\r\n        }\r\n\r\n    .alert-primary {\r\n        color: #004085;\r\n        background-color: #cce5ff;\r\n        border-color: #b8daff\r\n    }\r\n\r\n        .alert-primary hr {\r\n            border-top-color: #9fcdff\r\n        }\r\n\r\n        .alert-primary .alert-link {\r\n            color: #002752\r\n        }\r\n\r\n    .alert-secondary {\r\n        color: #383d41;\r\n        background-color: #e2e3e5;\r\n        border-color: #d6d8db\r\n    }\r\n\r\n        .alert-secondary hr {\r\n            border-top-color: #c8cbcf\r\n        }\r\n\r\n        .alert-secondary .alert-link {\r\n            color: #202326\r\n        }\r\n\r\n    .alert-success {\r\n        color: #155724;\r\n        background-color: #d4edda;\r\n        border-color: #c3e6cb\r\n    }\r\n\r\n        .alert-success hr {\r\n            border-top-color: #b1dfbb\r\n        }\r\n\r\n        .alert-success .alert-link {\r\n            color: #0b2e13\r\n        }\r\n\r\n    .alert-info {\r\n        color: #0c5460;\r\n        background-color: #d1ecf1;\r\n        border-color: #bee5eb\r\n    }\r\n\r\n        .alert-info hr {\r\n            border-top-color: #abdde5\r\n        }\r\n\r\n        .alert-info .alert-link {\r\n            color: #062c33\r\n        }\r\n\r\n    .alert-warning {\r\n        color: #856404;\r\n        background-color: #fff3cd;\r\n        border-color: #ffeeba\r\n    }\r\n\r\n        .alert-warning hr {\r\n            border-top-color: #ffe8a1\r\n        }\r\n\r\n        .alert-warning .alert-link {\r\n            color: #533f03\r\n        }\r\n\r\n    .alert-danger {\r\n        color: #721c24;\r\n        background-color: #f8d7da;\r\n        border-color: #f5c6cb\r\n    }\r\n\r\n        .alert-danger hr {\r\n            border-top-color: #f1b0b7\r\n        }\r\n\r\n        .alert-danger .alert-link {\r\n            color: #491217\r\n        }\r\n\r\n    .alert-light {\r\n        color: #818182;\r\n        background-color: #fefefe;\r\n        border-color: #fdfdfe\r\n    }\r\n\r\n        .alert-light hr {\r\n            border-top-color: #ececf6\r\n        }\r\n\r\n        .alert-light .alert-link {\r\n            color: #686868\r\n        }\r\n\r\n    .alert-dark {\r\n        color: #1b1e21;\r\n        background-color: #d6d8d9;\r\n        border-color: #c6c8ca\r\n    }\r\n\r\n        .alert-dark hr {\r\n            border-top-color: #b9bbbe\r\n        }\r\n\r\n        .alert-dark .alert-link {\r\n            color: #040505\r\n        }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Administrador\source\repos\AlertBlazorBootstrap\AlertBlazorBootstrap\Pages\Index.razor"
 
    TypeCss TypeCss = TypeCss.Primary;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
