#pragma checksum "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Pages\Notifications.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd4bc59cf03f6a9a29de7988fd309f85505600cb"
// <auto-generated/>
#pragma warning disable 1591
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
#line 4 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Notifications")]
    public partial class Notifications : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.AddMarkupContent(3, "<div class=\"container mt-5\">\r\n            <h2>My Notifications</h2>\r\n            <hr class=\"solid mt-5 custom_hr_solid\">\r\n        </div>\r\n\r\n        ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "container mt-3");
                __builder2.AddMarkupContent(6, "\r\n            ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.AddMarkupContent(9, "\r\n                ");
                __builder2.AddMarkupContent(10, "<div class=\"col-7 my-auto\">\r\n                    <p>Total Notifications: </p>\r\n                </div>\r\n                ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-5");
                __builder2.AddMarkupContent(13, "\r\n                    ");
                __builder2.OpenElement(14, "table");
                __builder2.AddAttribute(15, "class", "float-right");
                __builder2.AddMarkupContent(16, "\r\n                        ");
                __builder2.OpenElement(17, "tr");
                __builder2.AddMarkupContent(18, "\r\n                            ");
                __builder2.OpenElement(19, "td");
                __builder2.AddMarkupContent(20, "\r\n                                ");
                __builder2.OpenElement(21, "button");
                __builder2.AddAttribute(22, "class", "primary_button float-right");
                __builder2.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Pages\Notifications.razor"
                                                                                     AddNewNotification

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(24, "\r\n                                    Add Notification\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, @"<tr>
                            <td>
                                <button class=""primary_button float-right"">
                                    Export
                                </button>
                            </td>
                        </tr>
                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n\r\n\r\n        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "container mt-5");
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "jumbotron jumbotron-fluid shadow");
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "container");
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __builder2.AddMarkupContent(41, "<h5 class=\"display-5\">2pm - 5pm</h5>\r\n                    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "row");
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.AddMarkupContent(45, @"<div class=""col-10"">
                            <p class=""lead"">Notifications will be sent when transactions:</p>
                            <ul>
                                <li>Fall between 2pm -5pm.</li>
                            </ul>
                        </div>
                        ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-2");
                __builder2.AddMarkupContent(48, "\r\n                            ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "row");
                __builder2.AddMarkupContent(51, "\r\n                                ");
                __builder2.OpenElement(52, "button");
                __builder2.AddAttribute(53, "class", "btn float-right mr-5");
                __builder2.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Pages\Notifications.razor"
                                                                               AddNewNotification

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(55, "<i class=\"oi oi-pencil \"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                                ");
                __builder2.OpenElement(57, "button");
                __builder2.AddAttribute(58, "class", "btn float-right mr-5");
                __builder2.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Pages\Notifications.razor"
                                                                               AddNewNotification

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(60, "<i class=\"oi oi-trash\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "jumbotron jumbotron-fluid shadow");
                __builder2.AddMarkupContent(69, "\r\n                ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "container");
                __builder2.AddMarkupContent(72, "\r\n                    ");
                __builder2.AddMarkupContent(73, "<h5 class=\"display-5\">Out of State</h5>\r\n                    ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "row");
                __builder2.AddMarkupContent(76, "\r\n                        ");
                __builder2.AddMarkupContent(77, @"<div class=""col-10"">
                            <p class=""lead"">Notifications will be sent when transactions:</p>
                            <ul>
                                <li>Made Out-Of-State.</li>
                            </ul>
                        </div>
                        ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "col-2");
                __builder2.AddMarkupContent(80, "\r\n                            ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "row");
                __builder2.AddMarkupContent(83, "\r\n                                ");
                __builder2.OpenElement(84, "button");
                __builder2.AddAttribute(85, "class", "btn float-right mr-5");
                __builder2.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Pages\Notifications.razor"
                                                                               AddNewNotification

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(87, "<i class=\"oi oi-pencil \"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                                ");
                __builder2.OpenElement(89, "button");
                __builder2.AddAttribute(90, "class", "btn float-right mr-5");
                __builder2.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Pages\Notifications.razor"
                                                                               AddNewNotification

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(92, "<i class=\"oi oi-trash\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n            ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "jumbotron jumbotron-fluid shadow");
                __builder2.AddMarkupContent(101, "\r\n                ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "container");
                __builder2.AddMarkupContent(104, "\r\n                    ");
                __builder2.AddMarkupContent(105, "<h5 class=\"display-5\">In State + 12am-3am</h5>\r\n                    ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "row");
                __builder2.AddMarkupContent(108, "\r\n                        ");
                __builder2.AddMarkupContent(109, @"<div class=""col-10"">
                            <p class=""lead"">Notifications will be sent when transactions:</p>
                            <ul>
                                <li>Made In-State.</li>
                                <li>Fall between 12am -3am.</li>
                            </ul>
                        </div>
                        ");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "col-2");
                __builder2.AddMarkupContent(112, "\r\n                            ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "row");
                __builder2.AddMarkupContent(115, "\r\n                                ");
                __builder2.OpenElement(116, "button");
                __builder2.AddAttribute(117, "class", "btn float-right mr-5");
                __builder2.AddAttribute(118, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Pages\Notifications.razor"
                                                                               AddNewNotification

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(119, "<i class=\"oi oi-pencil \"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n                                ");
                __builder2.OpenElement(121, "button");
                __builder2.AddAttribute(122, "class", "btn float-right mr-5");
                __builder2.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Pages\Notifications.razor"
                                                                               AddNewNotification

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(124, "<i class=\"oi oi-trash\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n        \r\n\r\n");
#nullable restore
#line 98 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Pages\Notifications.razor"
         if (showPopup)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(132, "            ");
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "modal");
                __builder2.AddAttribute(135, "tabindex", "-1");
                __builder2.AddAttribute(136, "style", "display:block");
                __builder2.AddAttribute(137, "role", "dialog");
                __builder2.AddMarkupContent(138, "\r\n                ");
                __builder2.OpenElement(139, "div");
                __builder2.AddAttribute(140, "class", "modal-dialog");
                __builder2.AddMarkupContent(141, "\r\n                    ");
                __builder2.OpenElement(142, "div");
                __builder2.AddAttribute(143, "class", "modal-content");
                __builder2.AddMarkupContent(144, "\r\n\r\n                        ");
                __builder2.AddMarkupContent(145, "<div class=\"modal-header\">\r\n                            <h5 class=\"col-12 modal-title text-center\">ADD NOTIFICATION</h5>\r\n                        </div>\r\n\r\n                        ");
                __builder2.AddMarkupContent(146, "<div class=\"modal-body\">\r\n                            <hr class=\"solid custom_hr_solid mb-3\">\r\n\r\n                        </div>\r\n\r\n                        ");
                __builder2.OpenElement(147, "div");
                __builder2.AddAttribute(148, "class", "modal-footer");
                __builder2.AddMarkupContent(149, "\r\n                            ");
                __builder2.AddMarkupContent(150, "<button class=\"primary_button\">\r\n                                Add\r\n                            </button>\r\n                            ");
                __builder2.OpenElement(151, "button");
                __builder2.AddAttribute(152, "class", "primary_button ml-auto");
                __builder2.AddAttribute(153, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 117 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Pages\Notifications.razor"
                                                                             ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(154, "\r\n                                Cancel\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(155, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(156, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(157, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(158, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "\r\n");
#nullable restore
#line 124 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Pages\Notifications.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(160, "    ");
            }
            ));
            __builder.AddAttribute(161, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(162, "\r\n        ");
                __builder2.AddMarkupContent(163, "<div class=\"container mt-5\">\r\n            <h6>Please sign in to access your account information.</h6>\r\n        </div>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 136 "C:\Users\Sandy\Documents\GitHub\semester-project-group-5-commerce\CommerceASPIdentity\Pages\Notifications.razor"
       
    bool showPopup = false;

    void AddNewNotification()
    {
        showPopup = true;
    }

    void ClosePopup()
    {
        showPopup = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
