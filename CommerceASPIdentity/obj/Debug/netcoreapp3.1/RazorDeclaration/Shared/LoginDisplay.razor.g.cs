#pragma checksum "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50937e2461377b00171ff8c96ca232bfd947e164"
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
#line 1 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\_Imports.razor"
using EndToEndTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\_Imports.razor"
using EndToEndTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
using EndToEndTest.Data.CommerceDataModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : OwningComponentBase<TransactionSummary>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Shared\LoginDisplay.razor"
       
    public List<Transactionsmaster> transactionsList;
    public Dictionary<String, decimal> transDesc;

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
