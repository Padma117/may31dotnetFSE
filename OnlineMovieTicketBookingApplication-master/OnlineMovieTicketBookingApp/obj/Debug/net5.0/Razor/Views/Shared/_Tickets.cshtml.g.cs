#pragma checksum "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Tickets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43a165ad06ec9f29b0888d753f233719b8dfe668"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Tickets), @"mvc.1.0.view", @"/Views/Shared/_Tickets.cshtml")]
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
#line 1 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_ViewImports.cshtml"
using OnlineMovieTicketBookingApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43a165ad06ec9f29b0888d753f233719b8dfe668", @"/Views/Shared/_Tickets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a48618ddb37824892909c99ec05d07284e63f42", @"/Views/Shared/_ViewImports.cshtml")]
    public class Views_Shared__Tickets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineMovieTicketBookingApp.Models.Ticket>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n");
#nullable restore
#line 5 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Tickets.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\" style=\"width: 18rem;\">\n    <div class=\"card-body\">\n        <h5 class=\"card-title\"><b>Hall Number ");
#nullable restore
#line 10 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Tickets.cshtml"
                                         Write(item.hall_number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h5>\n        <h6 class=\"card-text\"><i> Seat Number  (");
#nullable restore
#line 11 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Tickets.cshtml"
                                           Write(item.seat_number);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</i></h6>\n        <p class=\"card-text\">\n            <br />\n            Show Time  ");
#nullable restore
#line 14 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Tickets.cshtml"
                  Write(item.show_datetime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n        </p>\n        <a");
            BeginWriteAttribute("href", " href=\'", 454, "\'", 524, 1);
#nullable restore
#line 17 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Tickets.cshtml"
WriteAttributeValue("", 461, Url.Action("Details", "Ticket" , new { id = item.ticket_id } ), 461, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <input type=\'button\' class=\"btn btn-warning\" value=\'View Details\' />\n        </a>\n    </div>\n</div>");
#nullable restore
#line 21 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Tickets.cshtml"
      }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineMovieTicketBookingApp.Models.Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
