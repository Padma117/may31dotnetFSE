#pragma checksum "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\BookingDetail\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf1bf9641972098845494839108459b9e7175486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookingDetail_Create), @"mvc.1.0.view", @"/Views/BookingDetail/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf1bf9641972098845494839108459b9e7175486", @"/Views/BookingDetail/Create.cshtml")]
    public class Views_BookingDetail_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMovieTicketBookingApp.Models.BookingDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\BookingDetail\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>BookingDetail</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""customer_id"" class=""control-label""></label>
                <input asp-for=""customer_id"" class=""form-control"" />
                <span asp-validation-for=""customer_id"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Order_Date_And_Time"" class=""control-label""></label>
                <input asp-for=""Order_Date_And_Time"" class=""form-control"" />
                <span asp-validation-for=""Order_Date_And_Time"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""booking_status"" class=""control-label""></label>
                <input asp-for=""booking_status"" class=""form-control"" />
               ");
            WriteLiteral(@" <span asp-validation-for=""booking_status"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""booking_totalamount"" class=""control-label""></label>
                <input asp-for=""booking_totalamount"" class=""form-control"" />
                <span asp-validation-for=""booking_totalamount"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""seat_number"" class=""control-label""></label>
                <input asp-for=""seat_number"" class=""form-control"" />
                <span asp-validation-for=""seat_number"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Ticket_Id"" class=""control-label""></label>
                <select asp-for=""Ticket_Id"" class =""form-control"" asp-items=""ViewBag.Ticket_Id""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""show_id"" class=""cont");
            WriteLiteral(@"rol-label""></label>
                <input asp-for=""show_id"" class=""form-control"" />
                <span asp-validation-for=""show_id"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ticket_qty"" class=""control-label""></label>
                <input asp-for=""ticket_qty"" class=""form-control"" />
                <span asp-validation-for=""ticket_qty"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 67 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\BookingDetail\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMovieTicketBookingApp.Models.BookingDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
