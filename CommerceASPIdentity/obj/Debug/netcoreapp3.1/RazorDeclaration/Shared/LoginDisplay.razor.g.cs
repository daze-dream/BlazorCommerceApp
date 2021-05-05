// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 10 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\_Imports.razor"
using Utils;

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
    public partial class LoginDisplay : OwningComponentBase<NotificationServices>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
       
    public List<TriggeredNotif> notifSummaries;

    public List<Tuple<String, decimal>> transDesc;
    private string userID;

    private string displayBell = "d-none";

    protected override async Task OnInitializedAsync()
    {
        var user = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User;
        userID = user.FindFirst(c => c.Type.Contains("nameidentifier"))?.Value;

        notifSummaries = await Service.GetTriggeredNotifSummary(user.Identity.Name);
        notifSummaries.Count();
        notifSummaries.Count();
        notifSummaries.Count();
        notifSummaries.Count();



    }

    private async Task displayNotifBell()
    {
        if (displayBell == "d-block")
        {
            displayBell = "d-none";
            //notifSummaries.Clear();
        }
        else
        {
            notifSummaries = await Service.GetTriggeredNotifSummary(userID);
            displayBell = "d-block";
        }
    }




    public int getIndexOfSubstring(string text, string toMatch)
    {
        return text.IndexOf(toMatch);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor HttpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
