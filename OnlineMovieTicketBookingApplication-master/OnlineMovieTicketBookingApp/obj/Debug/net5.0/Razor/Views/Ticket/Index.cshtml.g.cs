#pragma checksum "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Ticket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39b698fac52f04a34a11256a67e63be0d25fd49c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_Index), @"mvc.1.0.view", @"/Views/Ticket/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39b698fac52f04a34a11256a67e63be0d25fd49c", @"/Views/Ticket/Index.cshtml")]
    public class Views_Ticket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineMovieTicketBookingApp.Models.Ticket>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Ticket\Index.cshtml"
   ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<style>\n        body {\n            background-color: black;\n        }\n\n        .card {\n");
            WriteLiteral(@"            /*left: 30px;*/
            top: 20px;
            text-align: center;
            color: white;
            background-color: black;
            font-family: Arial, Helvetica, sans-serif;
            float: left;
            margin: 5px;
        }

        .card-img-top {
            width: 60%;
            height: auto;
            object-fit: cover;
        }


        .card-text {
            font-size: 12px;
        }

        .card-title {
            font-size: 13px;
        }

        .card-link {
            font-size: 12px;
            color: lightsteelblue;
        }


    .tabcontent {
        display: none;
        padding: 6px 12px;
        /*border: 1px solid #ccc;*/
        border-top: none;
    }

    .nav-pills > li > a {
        color: white !important;
    }

    .tab {
        margin: 5px;
        left: 10px;
    }

    .nav-pills > li > a.active {
        background-color: white !important;
        color: black !important;
    }

    .nav-pills > li > a:hover {
        backgr");
            WriteLiteral(@"ound-color: gray !important;
        color: white !important;
    }

    /*.nav-link-color {
        color: black !important;
    }*/

    .coming-soon{
        color:black;
    }
</style>
<h1>  Welcome User </h1>
<script>
    function displayTickets(evt, status) {
        // Declare all variables
        var i, tabcontent, tablinks;

        // Get all elements with class=""tabcontent"" and hide them
        tabcontent = document.getElementsByClassName(""tabcontent"");
        for (i = 0; i < tabcontent.length; i++) {
            tabcontent[i].style.display = ""none"";
        }

        // Get all elements with class=""tablinks"" and remove the class ""active""
        tablinks = document.getElementsByClassName(""tablinks"");
        for (i = 0; i < tablinks.length; i++) {
            tablinks[i].className = tablinks[i].className.replace("" active"", """");
        }

        // Show the current tab, and add an ""active"" class to the button that opened the tab
        document.getElementById(status).style.display = ""block"";");
            WriteLiteral("\n        evt.currentTarget.className += \" active\";\n    }\n\n</script>\n\n\n<div class=\"tab-content\" id=\"pills-tabContent\">\n    <div class=\"tab-pane fade show active tabcontent\" id=\"now-showing\" role=\"tabpanel\" aria-labelledby=\"pills-home-tab\">");
#nullable restore
#line 105 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Ticket\Index.cshtml"
                                                                                                                   Write(await Html.PartialAsync("_Tickets"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n</div>\n\n");
            WriteLiteral("\n\n\n\n");
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
