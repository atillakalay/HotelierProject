#pragma checksum "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b49822c38893a565acbb2389bcb5fc520730d6cd305823bb26e80efce5b2d1cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Index), @"mvc.1.0.view", @"/Views/Staff/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b49822c38893a565acbb2389bcb5fc520730d6cd305823bb26e80efce5b2d1cf", @"/Views/Staff/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d396da14f90ee360fee5fd0ee19c2bfd0a299961227485e0d0a3588f708b415a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Staff_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StaffViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"table table-bordered\">\n    <tr>\n        <th>#</th>\n        <th>Personel Adı</th>\n        <th>Personel Ünvan</th>\n        <th>Sil</th>\n        <th>Güncelle</th>\n        <th>Detaylar</th>\n    </tr>\n");
#nullable restore
#line 17 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <th>");
#nullable restore
#line 20 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
           Write(item.StaffID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <td>");
#nullable restore
#line 21 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 22 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 504, "\"", 543, 2);
            WriteAttributeValue("", 511, "/Staff/DeleteStaff/", 511, 19, true);
#nullable restore
#line 23 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
WriteAttributeValue("", 530, item.StaffID, 530, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-danger\">Sil</a></td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 624, "\"", 663, 2);
            WriteAttributeValue("", 631, "/Staff/UpdateStaff/", 631, 19, true);
#nullable restore
#line 24 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
WriteAttributeValue("", 650, item.StaffID, 650, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-success\">Güncelle</a></td>\n            <td><a href=\"#\" class=\"btn mb-1 btn-rounded btn-outline-dark\">Detaylar</a></td>\n        </tr>\n");
#nullable restore
#line 27 "C:\Users\Atilla\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n<a href=\"/Staff/AddStaff/\" class=\"btn mb-1 btn-rounded btn-outline-info\">Yeni Personel Girişi</a>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StaffViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
