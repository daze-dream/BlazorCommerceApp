#pragma checksum "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4506842cecf8f6a92bc175bb66afdddc40dc8c3f"
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
#line 1 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\_Imports.razor"
using EndToEndTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\_Imports.razor"
using EndToEndTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\_Imports.razor"
using Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Shared\LoginDisplay.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Shared\LoginDisplay.razor"
using EndToEndTest.Data.CommerceDataModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Shared\LoginDisplay.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Shared\LoginDisplay.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Shared\LoginDisplay.razor"
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
                __builder2.OpenElement(12, "i");
                __builder2.AddAttribute(13, "class", "oi oi-bell ml-3");
                __builder2.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Shared\LoginDisplay.razor"
                                                      displayNotifBell

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(15, "\r\n                    ");
                __builder2.OpenElement(16, "a");
                __builder2.AddAttribute(17, "class", 
#nullable restore
#line 28 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Shared\LoginDisplay.razor"
                               displayBell

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(18, "href", "Notifications");
                __builder2.AddMarkupContent(19, "\r\n                        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "dropdown-content");
                __builder2.AddMarkupContent(22, "\r\n");
#nullable restore
#line 30 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Shared\LoginDisplay.razor"
                             if (notifications.Count == 0)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(23, "                            ");
                __builder2.AddMarkupContent(24, "<div class=\"row notifAlerts\">\r\n                                <span class=\"alertMess\">No notifications to display</span>\r\n                            </div>\r\n");
#nullable restore
#line 35 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Shared\LoginDisplay.razor"
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Shared\LoginDisplay.razor"
                                 foreach (var x in notifications) //for every transactions made
                            {


#line default
#line hidden
#nullable disable
                __builder2.AddContent(25, "                                ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "row notifAlerts");
                __builder2.AddMarkupContent(28, "\r\n                                    ");
                __builder2.OpenElement(29, "span");
                __builder2.AddAttribute(30, "class", "alertMess");
                __builder2.AddContent(31, 
#nullable restore
#line 42 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Shared\LoginDisplay.razor"
                                                             x.EmailBody.Substring(131).Substring(0, getIndexOfSubstring(x.EmailBody.Substring(131), "If"))

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n");
#nullable restore
#line 44 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Shared\LoginDisplay.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Shared\LoginDisplay.razor"
                             
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(34, "                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.AddMarkupContent(39, "<a class=\"nav-link\" href=\"Notifications\">Notifications</a>\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.AddMarkupContent(41, "<div class=\"row align-items-center ml-1\">\r\n            <form method=\"post\" action=\"Identity/Account/LogOut\">\r\n                <button type=\"submit\" class=\"btn nav_bar_button\">Log out</button>\r\n            </form>\r\n        </div>\r\n    ");
            }
            ));
            __builder.AddAttribute(42, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.AddMarkupContent(44, "<div class=\"row align-items-center ml-3\"><a class=\"nav-link\" href=\"/\">About</a></div>\r\n        ");
                __builder2.AddMarkupContent(45, "<div class=\"row align-items-center ml-1\"><a href=\"Identity/Account/RegisterAsp\" style=\"margin-left: 12px\">Register</a></div>\r\n        ");
                __builder2.AddMarkupContent(46, "<div class=\"row align-items-center ml-3\"><a href=\"Identity/Account/Login\" style=\"margin-right: 5px\">Log in</a></div>\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Shared\LoginDisplay.razor"
       
    public List<Transactionsmaster> transactionsList;
    public List<Tuple<String, decimal>> transDesc;
    public List<TriggeredNotif> notifications;
    private string userEmail;

    private string displayBell = "d-none";

    private async Task displayNotifBell()
    {
        if (displayBell == "d-none")
            displayBell = "d-block";
        else
            displayBell = "d-none";
        //transactionsList = await Service.GetRecentTransaction(userID);
        //transDesc = await Service.getTransactionDescription(userID);
        notifications = await Service.getRecentTriggeredNotif(userEmail);
    }

    protected override async Task OnInitializedAsync()
    {
        var user = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User;
        string userID = user.FindFirst(c => c.Type.Contains("nameidentifier"))?.Value;
        userEmail = user.Identity.Name;

        transactionsList = await Service.GetRecentTransaction(userID);
        transDesc = await Service.getTransactionDescription(userID);
        notifications = await Service.getRecentTriggeredNotif(userEmail);
    }

    public MarkupString getHTMLMarkup(string text)
    {
        return (MarkupString)text;
    }

    public int getIndexOfSubstring(string text, string toMatch)
    {
        return text.IndexOf(toMatch);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager MyNavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor HttpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
