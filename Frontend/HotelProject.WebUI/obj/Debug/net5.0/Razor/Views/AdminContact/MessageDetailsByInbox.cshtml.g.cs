#pragma checksum "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminContact\MessageDetailsByInbox.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cd5c8694b005b7b6acd87bfe675c1c8297d15bacabfe55ffc00da0f8cc98f558"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminContact_MessageDetailsByInbox), @"mvc.1.0.view", @"/Views/AdminContact/MessageDetailsByInbox.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Staff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Testimonial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ServiceDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RegisterDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.LoginDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.AboutDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RoomDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.TestimonialDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.StaffDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.BookingDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ContactDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.GuestDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.SendMessageDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.WorkLocationDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.AppUserDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Role;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Setting;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cd5c8694b005b7b6acd87bfe675c1c8297d15bacabfe55ffc00da0f8cc98f558", @"/Views/AdminContact/MessageDetailsByInbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d396da14f90ee360fee5fd0ee19c2bfd0a299961227485e0d0a3588f708b415a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminContact_MessageDetailsByInbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InboxContactDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-3 rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminweb/images/avatar/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminContact\MessageDetailsByInbox.cshtml"
  
    ViewData["Title"] = "MessageDetailsByInbox";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"email-left-box\">\n    <a href=\"/AdminContact/AddSendMessage/\" class=\"btn btn-primary btn-block\">Yeni Mesaj Oluştur</a>\n    ");
#nullable restore
#line 9 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminContact\MessageDetailsByInbox.cshtml"
Write(await Html.PartialAsync("SideBarAdminContactPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <h5 class=\"mt-5 m-b-10\">Kategoriler</h5>\n    ");
#nullable restore
#line 11 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminContact\MessageDetailsByInbox.cshtml"
Write(await Html.PartialAsync("SideBarAdminContactCategoryPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
<div class=""email-right-box"">
    <div role=""toolbar"" class=""toolbar"">
        <div class=""btn-group"">
            <button aria-expanded=""false"" data-toggle=""dropdown"" class=""btn btn-dark dropdown-toggle"" type=""button"">
                Gelen Mesajlar <span class=""caret m-l-5""></span>
            </button>
        </div>
    </div>

    <div class=""read-content"">
        <div class=""media pt-5"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cd5c8694b005b7b6acd87bfe675c1c8297d15bacabfe55ffc00da0f8cc98f5589934", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <div class=\"media-body\">\n                <h5 class=\"m-b-3\">");
#nullable restore
#line 26 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminContact\MessageDetailsByInbox.cshtml"
                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <p class=\"m-b-2\">");
#nullable restore
#line 27 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminContact\MessageDetailsByInbox.cshtml"
                             Write(((DateTime)Model.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n\n        </div>\n        <hr>\n        <div class=\"media mb-4 mt-1\">\n            <div class=\"media-body\">\n                <h4 class=\"m-0 text-primary\">");
#nullable restore
#line 34 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminContact\MessageDetailsByInbox.cshtml"
                                        Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4><small class=\"text-muted\">Mail :");
#nullable restore
#line 34 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminContact\MessageDetailsByInbox.cshtml"
                                                                                           Write(Model.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n            </div>\n        </div>\n        <p>");
#nullable restore
#line 37 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminContact\MessageDetailsByInbox.cshtml"
      Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <hr>\n    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InboxContactDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
