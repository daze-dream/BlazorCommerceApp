// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EndToEndTest.Pages
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
#line 2 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Pages\Transactions.razor"
using EndToEndTest.Data.CommerceDataModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Pages\Transactions.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Pages\Transactions.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Transactions")]
    public partial class Transactions : OwningComponentBase<TransactionServices>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 192 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Pages\Transactions.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    List<Transactionsmaster> transactionsList;
    List<Accounts> usersBankAccount;


    Transactionsmaster objTransactionsmaster = new Transactionsmaster();
    bool showPopup = false;
    private readonly IHttpContextAccessor _httpCA;
    string credit = "CR";
    string debit = "DR";

    public class States { public string Abbrev { get; set; } };
    // THINK ABOUT CREATING SEPERATE MODEL OF THIS LIST OF STATES - BUT MAYBE NOT, ONLY NEEDED IN THIS PAGE. DOES NOT NEED TO BE SHARED.
    List<States> allStates = new List<States>
{
        new States() {Abbrev= "AL"}, new States() {Abbrev= "AK"}, new States() {Abbrev= "AZ"},
        new States() {Abbrev= "AR"}, new States() {Abbrev= "CA"}, new States() {Abbrev= "CO"},
        new States() {Abbrev= "CT"}, new States() {Abbrev= "DC"}, new States() {Abbrev= "DE"},
        new States() {Abbrev= "FL"}, new States() {Abbrev= "GA"}, new States() {Abbrev= "HI"},
        new States() {Abbrev= "ID"}, new States() {Abbrev= "IL"}, new States() {Abbrev= "IN"},
        new States() {Abbrev= "IA"}, new States() {Abbrev= "KS"}, new States() {Abbrev= "KY"},
        new States() {Abbrev= "LA"}, new States() {Abbrev= "ME"}, new States() {Abbrev= "MD"},
        new States() {Abbrev= "MA"}, new States() {Abbrev= "MI"}, new States() {Abbrev= "MN"},
        new States() {Abbrev= "MS"}, new States() {Abbrev= "MO"}, new States() {Abbrev= "MT"},
        new States() {Abbrev= "NE"}, new States() {Abbrev= "NV"}, new States() {Abbrev= "NH"},
        new States() {Abbrev= "NJ"}, new States() {Abbrev= "NM"}, new States() {Abbrev= "NY"},
        new States() {Abbrev= "NC"}, new States() {Abbrev= "ND"}, new States() {Abbrev= "OH"},
        new States() {Abbrev= "OK"}, new States() {Abbrev= "OR"}, new States() {Abbrev= "PA"},
        new States() {Abbrev= "RI"}, new States() {Abbrev= "SC"}, new States() {Abbrev= "SD"},
        new States() {Abbrev= "TN"}, new States() {Abbrev= "TX"}, new States() {Abbrev= "UT"},
        new States() {Abbrev= "VA"}, new States() {Abbrev= "VT"}, new States() {Abbrev= "WA"},
        new States() {Abbrev= "WV"}, new States() {Abbrev= "WI"}, new States() {Abbrev= "WY"}
    };

    private decimal getBalance(decimal? thebal, decimal amount)
    {
        return ((Convert.ToDecimal(thebal)) + amount);
    }


    /// <summary>get the transactions when loading in the page </summary>
    protected override async Task OnInitializedAsync()
    {
        var user = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User;
        string userId = user.FindFirst(c => c.Type.Contains("nameidentifier"))?.Value;

        transactionsList = await Service.GetTransactions(userId);
        usersBankAccount = await Service.GetAccount(userId);
    }
    /// <summary>bool to open and close the Transaction popup</summary>
    void ClosePopup()
    {
        showPopup = false;
    }
    /// <summary>
    /// prepares the transaction to be added
    /// </summary>
    void AddNewTransaction()
    {
        objTransactionsmaster = new Transactionsmaster();
        objTransactionsmaster.TransactionId = 0;
        showPopup = true;
    }

    /// <summary>
    /// creates the final transaction and saves it to the server. Then, refreshes the view to update the account and transactions view
    /// </summary>
    /// <returns> Task, or rather nothing </returns>
    async Task SaveTransaction()
    {
        showPopup = false;
        // get current userID
        var user = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User;
        string userId = user.FindFirst(c => c.Type.Contains("nameidentifier"))?.Value;
        if (objTransactionsmaster.AccountId == 0)
        {
            Transactionsmaster newTrans = new Transactionsmaster();
            newTrans.UserId = userId;
            newTrans.AccountId = await Service.getUsersBankAccountID(userId);
            newTrans.Transactiondate = System.DateTime.Now;
            newTrans.Openingbalance = Convert.ToDecimal(await Service.GetAccountCurrentBalance(newTrans.AccountId));

            newTrans.Transactiontype = objTransactionsmaster.Transactiontype;
            if (objTransactionsmaster.Transactiontype == "DR")
            {
                newTrans.Transactionamount = objTransactionsmaster.Transactionamount * -1;
            }
            else
            {
                newTrans.Transactionamount = objTransactionsmaster.Transactionamount;
            }

            newTrans.Description = objTransactionsmaster.Description;
            newTrans.LocationState = objTransactionsmaster.LocationState;
            var result = Service.CreateTransactionAsync(newTrans);
            await Service.updateUsersBankBalanceAfterTransaction(newTrans, userId);
        }
        else
        {
            // updates
        }
        // refreshes the transactions afterwards
        transactionsList = await Service.GetTransactions(userId);
        usersBankAccount = await Service.GetAccount(userId);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor HttpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
