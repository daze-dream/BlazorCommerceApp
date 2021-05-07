#pragma checksum "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Pages\Notifications.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a7d1145b19122415b40c0d26bffa62a461a2644"
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
#line 10 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\_Imports.razor"
using Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Pages\Notifications.razor"
using EndToEndTest.Data.CommerceDataModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Pages\Notifications.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Pages\Notifications.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Pages\Notifications.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Pages\Notifications.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Pages\Notifications.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Notifications")]
    public partial class Notifications : OwningComponentBase<NotificationServices>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 326 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Pages\Notifications.razor"
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    List<AmountConstraint> ac;
    List<TimeConstraint> tc;
    List<LocationConstraint> lc;
    List<UserToNotifications> notifList;

    DateTime tempMin;
    DateTime tempMax;

    AmountConstraint tempAC = new AmountConstraint();
    TimeConstraint tempTC = new TimeConstraint();
    LocationConstraint tempLC = new LocationConstraint();

    private bool smallPopUp = false;
    private bool showPopup = false;
    private bool hideDivAmt = true;
    private bool hideDivLoc = true;
    private bool hideDivTm = true;
    private bool hideSmAmt = true;
    private bool hideSmTime = true;
    private bool hideSmLoc = true;
    private string hideAmt => hideDivAmt ? "d-none" : null;
    private string hideLoc => hideDivLoc ? "d-none" : null;
    private string hideTm => hideDivTm ? "d-none" : null;
    private string hideAmtSm => hideSmAmt ? "d-none" : null;
    private string hideLocSm => hideSmLoc ? "d-none" : null;
    private string hideTmSm => hideSmTime ? "d-none" : null;
    private string message = "";
    private string ty = "";

    /// <summary>
    /// Requires a string parameter. Assigns a value to the string "ty". Helps to determine which type of button should be displayed.
    /// </summary>
    /// <param name="e"></param>
    private void selectType(string e)
    {
        ty = e;
    }

    /// <summary>
    /// Functions that aid in Modal popups and hiding Div containers.
    /// </summary>
    void AddNewNotification()
    {
        showPopup = true;
    }
    void ClosePopupOriginal()
    {
        showPopup = false;
    }
    void CloseSmallPopup()
    {
        smallPopUp = false;
        hideSmAmt = true;
        hideSmTime = true;
        hideSmLoc = true;
    }
    private void hideAmountCon()
    {
        hideDivAmt = false;
        hideDivLoc = true;
        hideDivTm = true;
    }
    private void hideLocCon()
    {
        hideDivAmt = true;
        hideDivLoc = false;
        hideDivTm = true;
    }
    private void hideTimeCon() {
        hideDivAmt = true;
        hideDivLoc = true;
        hideDivTm = false;
    }
    private void hideSmAmount()
    {
        hideSmAmt = !hideSmAmt;
    }
    private void hideSmTimes()
    {
        hideSmTime = !hideSmTime;
    }
    private void hideSmLocation()
    {
        hideSmLoc = !hideSmLoc;
    }

    /// <summary>
    /// Initializes all the appropriate variables to be displayed as soon as the page is loaded.
    /// </summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()
    {
        var user = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User;
        string userId = user.FindFirst(c => c.Type.Contains("nameidentifier"))?.Value;

        notifList = await Service.GetNotifJoinTable(userId);
        ac = await Service.GetAmountConstraints(notifList);
        tc = await Service.GetTimeConstraints(notifList);
        lc = await Service.GetLocationConstraints(notifList);
    }

    /// <summary>
    /// Prepares new notification to be added, used in the HTML forms. Checks incoming object type to determine what to add.
    /// Each scenario first adds a new entry to the join table, then to the corresponding table.
    /// </summary>
    async Task SaveNotification(object x)
    {
        var user = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User;
        string userId = user.FindFirst(c => c.Type.Contains("nameidentifier"))?.Value;
        if (x is AmountConstraint)
        {
            if (tempAC.NotificationId == 0)
            {
                prepareNewUserToNotifJoinEntry(userId);
                AmountConstraint newNotif = (AmountConstraint)x;
                newNotif.Min = tempAC.Min;
                newNotif.Max = tempAC.Max;
                newNotif.NotificationId = await Service.GetMostRecentNotifJoinTableRule(userId);
                var result = Service.AddAmountNotification(newNotif);
            }
            else
            {
                var result = Service.updateNotificationsAsync(tempAC);
            }
        }
        else if (x is TimeConstraint)
        {
            if (tempTC.NotificationId == 0)
            {
                prepareNewUserToNotifJoinEntry(userId);
                TimeConstraint newNotif = (TimeConstraint)x;
                newNotif.TimeIn = tempMin.TimeOfDay;
                newNotif.TimeOut = tempMax.TimeOfDay;
                newNotif.NotificationId = await Service.GetMostRecentNotifJoinTableRule(userId);

                var result = Service.AddTimeNotification(newNotif);
            }
            else
            {
                tempTC.TimeIn = tempMin.TimeOfDay;
                tempTC.TimeOut = tempMax.TimeOfDay;
                var result = Service.updateNotificationsAsync(tempTC);

            }
        }
        else if (x is LocationConstraint)
        {
            if (tempLC.NotificationId == 0)
            {
                prepareNewUserToNotifJoinEntry(userId);
                LocationConstraint newNotif = (LocationConstraint)x;
                newNotif.Location = tempLC.Location;
                newNotif.NotificationId = await Service.GetMostRecentNotifJoinTableRule(userId);

                var result = Service.AddLocationNotification(newNotif);
            }
            else
            {
                var result = Service.updateNotificationsAsync(tempLC);

            }
        }
        //showPopup = false;
        if(smallPopUp == true)
        {
            smallPopUp = false;
            NavMan.NavigateTo("Notifications", true);
        }
        if (showPopup == true)
        {
            showPopup = false;
            NavMan.NavigateTo("Notifications", true);
        }

        notifList = await Service.GetNotifJoinTable(userId);
        ac = await Service.GetAmountConstraints(notifList);
        tc = await Service.GetTimeConstraints(notifList);
        lc = await Service.GetLocationConstraints(notifList);
    }

    /// <summary>
    /// Requires an object parameter. Deletes entries from the database given the parameter.
    /// </summary>
    /// <param name="notif"></param>
    /// <returns></returns>
    async Task DeleteNotif(object notif)
    {
        var user = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User;
        string userId = user.FindFirst(c => c.Type.Contains("nameidentifier"))?.Value;

        var result = Service.DeleteNotificationAsync(notif);

        notifList = await Service.GetNotifJoinTable(userId);
        ac = await Service.GetAmountConstraints(notifList);
        tc = await Service.GetTimeConstraints(notifList);
        lc = await Service.GetLocationConstraints(notifList);
    }

    void prepareNewUserToNotifJoinEntry(string userID)
    {
        UserToNotifications newEntry = new UserToNotifications();
        newEntry.UserId = userID;
        Service.AddNewUsersToNotifJoinTableEntry(newEntry);

    }

    /// <summary>
    /// Requires a TimeSpan parameter. Converts the Timespan and outputs a string.
    /// </summary>
    /// <param name="theDateTime"></param>
    /// <returns></returns>
    string revertDateTime(TimeSpan theDateTime)
    {
        DateTime time = DateTime.Today.Add(theDateTime);
        string convertedTime = time.ToString("h:mm tt");
        return convertedTime;
    }

    /// <summary>
    /// Sets the value of "counter" to display the total number of active notification rules.
    /// </summary>
    /// <returns></returns>
    int returnCount()
    {
        int counter = 0;
        if (ac != null)
        {
            counter += ac.Count;
        }
        if (lc != null)
        {
            counter += lc.Count;
        }
        if (tc != null)
        {
            counter += tc.Count;
        }
        return counter;
    }

    /// <summary>
    /// Requires an object parameter. Sets the visibility of div containers, values, and existing database values for editing.
    /// </summary>
    /// <param name="notif"></param>
    void EditNotif(object notif)
    {
        if (notif is AmountConstraint)
        {
            tempAC = (AmountConstraint)notif;
            smallPopUp = true;
            hideSmAmt = false;
            message = "Enter a new minimum and maximum dollar amount";
            ty = "amount";
        }
        else if (notif is TimeConstraint)
        {
            tempTC = (TimeConstraint)notif;
            tempMin = Convert.ToDateTime(tempTC.TimeIn.ToString());
            tempMax = Convert.ToDateTime(tempTC.TimeOut.ToString());
            smallPopUp = true;
            hideSmTime = false;
            message = "Select a new start and end time.";
            ty = "time";
        }
        else if (notif is LocationConstraint)
        {
            tempLC = (LocationConstraint)notif;
            smallPopUp = true;
            hideSmLoc = false;
            message = "Enter a new description.";
            ty = "location";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor HttpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
