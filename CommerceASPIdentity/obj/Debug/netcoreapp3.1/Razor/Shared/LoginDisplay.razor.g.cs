#pragma checksum "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87671654eff20491cbaf53535402adae02e7e36a"
// <auto-generated/>
#pragma warning disable 1591
namespace EndToEndTest.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\_Imports.razor"
using EndToEndTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\_Imports.razor"
using EndToEndTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
using EndToEndTest.Data.CommerceDataModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : OwningComponentBase<TransactionSummary>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.AddMarkupContent(3, "<div class=\"row align-items-center ml-3\"><a class=\"nav-link\" href=\"/\">About</a></div>\r\n        ");
                __builder2.AddMarkupContent(4, "<div class=\"row align-items-center ml-3\"><a class=\"nav-link\" href=\"Dashboard\">Dashboard</a></div>\r\n        ");
                __builder2.AddMarkupContent(5, "<div class=\"row align-items-center ml-3\"><a class=\"nav-link\" href=\"Transactions\">Transactions</a></div>\r\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row align-items-center ml-3");
                __builder2.AddMarkupContent(8, "\r\n            \r\n            ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "dropdown");
                __builder2.AddMarkupContent(11, "\r\n                ");
                __builder2.OpenElement(12, "a");
                __builder2.AddAttribute(13, "class", 
#nullable restore
#line 25 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
                           displayBell

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
                                                   displayNotifBell

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "href", "Notifications");
                __builder2.AddMarkupContent(16, "<i class=\"oi oi-bell ml-3\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "dropdown-content");
                __builder2.AddMarkupContent(20, "\r\n");
#nullable restore
#line 27 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
                     foreach (var x in transDesc) //for every transactions made
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(21, "                ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "row notifAlerts");
                __builder2.AddMarkupContent(24, "\r\n                    ");
                __builder2.OpenElement(25, "span");
                __builder2.AddAttribute(26, "class", "alertMess");
                __builder2.AddContent(27, "$");
                __builder2.AddContent(28, 
#nullable restore
#line 30 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
                                              x.Value

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(29, " from ");
                __builder2.AddContent(30, 
#nullable restore
#line 30 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
                                                            x.Key

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n");
#nullable restore
#line 32 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(33, "                    \r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.AddMarkupContent(36, "<a class=\"nav-link\" href=\"Notifications\">Notifications</a>\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.AddMarkupContent(38, "<div class=\"row align-items-center ml-1\">\r\n            <form method=\"post\" action=\"Identity/Account/LogOut\">\r\n                <button type=\"submit\" class=\"btn nav_bar_button\">Log out</button>\r\n            </form>\r\n        </div>\r\n\r\n    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.OpenElement(41, "button");
                __builder2.AddAttribute(42, "class", "btn-sm");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
                                          displayNotifBell

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(44, "Display");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n    ");
            }
            ));
            __builder.AddAttribute(47, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.AddMarkupContent(49, "<div class=\"row align-items-center ml-3\"><a class=\"nav-link\" href=\"/\">About</a></div>\r\n        ");
                __builder2.AddMarkupContent(50, "<div class=\"row align-items-center ml-3\"><a href=\"Identity/Account/Register\">Register</a></div>\r\n        ");
                __builder2.AddMarkupContent(51, "<div class=\"row align-items-center ml-3\"><a href=\"Identity/Account/Login\">Log in</a></div>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
       
    public List<Transactionsmaster> transactionsList;
    public Dictionary<String, decimal> transDesc;
    private string displayBell = "d-none";

    private void displayNotifBell()
    {
        if (displayBell == "d-block")
        {
            displayBell = "d-none";
        }
        else displayBell = "d-block";
    }

    protected override async Task OnInitializedAsync()
    {
        var user = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User;
        string userID = user.FindFirst(c => c.Type.Contains("nameidentifier"))?.Value;

        transactionsList = await Service.GetRecentTransaction(userID);
        transDesc = await Service.getTransactionDescription(userID);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor HttpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
