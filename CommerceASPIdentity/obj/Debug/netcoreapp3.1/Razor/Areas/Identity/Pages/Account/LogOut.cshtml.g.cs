<<<<<<< HEAD
#pragma checksum "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Areas\Identity\Pages\Account\LogOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "580e87faa4f26b07c32280b4a4a19c3f61b16786"
=======
#pragma checksum "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Areas\Identity\Pages\Account\LogOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "580e87faa4f26b07c32280b4a4a19c3f61b16786"
>>>>>>> main
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_LogOut), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/LogOut.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Areas\Identity\Pages\_ViewImports.cshtml"
=======
#line 2 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Areas\Identity\Pages\_ViewImports.cshtml"
>>>>>>> main
using EndToEndTest.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Areas\Identity\Pages\_ViewImports.cshtml"
=======
#line 3 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Areas\Identity\Pages\_ViewImports.cshtml"
>>>>>>> main
using EndToEndTest.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 1 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Areas\Identity\Pages\Account\_ViewImports.cshtml"
=======
#line 1 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Areas\Identity\Pages\Account\_ViewImports.cshtml"
>>>>>>> main
using EndToEndTest.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Areas\Identity\Pages\Account\LogOut.cshtml"
=======
#line 2 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Areas\Identity\Pages\Account\LogOut.cshtml"
>>>>>>> main
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Areas\Identity\Pages\Account\LogOut.cshtml"
=======
#line 3 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Areas\Identity\Pages\Account\LogOut.cshtml"
>>>>>>> main
           [IgnoreAntiforgeryToken]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"580e87faa4f26b07c32280b4a4a19c3f61b16786", @"/Areas/Identity/Pages/Account/LogOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"299a3562d6e52f47f897136ea72b4d902475debf", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d3cc6c489340ac1c1339fac2ac41f94cdebfe55", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_LogOut : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 5 "C:\Users\degag\source\repos\commerce\CommerceASPIdentity\Areas\Identity\Pages\Account\LogOut.cshtml"
=======
#line 5 "C:\Users\miste\Desktop\School Stuff\CS 451 Capstone\CommerceApp\davidhoang\CommerceASPIdentity\Areas\Identity\Pages\Account\LogOut.cshtml"
>>>>>>> main
            
    public async Task<IActionResult> OnPost()
    {
        if (SignInManager.IsSignedIn(User))
        {
            await SignInManager.SignOutAsync();
        }

        return Redirect("~/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Identity_Pages_Account_LogOut> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_LogOut> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_LogOut>)PageContext?.ViewData;
        public Areas_Identity_Pages_Account_LogOut Model => ViewData.Model;
    }
}
#pragma warning restore 1591
