#pragma checksum "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8df3a3f60fc298bcad2decd29666b60b9c201d41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8df3a3f60fc298bcad2decd29666b60b9c201d41", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a48618ddb37824892909c99ec05d07284e63f42", @"/Views/Shared/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/MiscImages/Logo2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline-block align-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8df3a3f60fc298bcad2decd29666b60b9c201d415447", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
#nullable restore
#line 6 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    <script src=\"https://code.jquery.com/jquery-1.12.4.js\"></script>\r\n    <script src=\"https://code.jquery.com/ui/1.12.1/jquery-ui.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8df3a3f60fc298bcad2decd29666b60b9c201d416204", async() => {
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
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8df3a3f60fc298bcad2decd29666b60b9c201d418094", async() => {
                WriteLiteral(@"

    <div>
        <!--<nav class=""navbar navbar-expand-lg navbar-dark bg-dark"">
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarTogglerDemo03"" aria-controls=""navbarTogglerDemo03"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <a class=""navbar-brand"" href=""/Home/Index"">
            <img src=""~/MiscImages/Logo2.jpg"" width=""30"" height=""30"" class=""d-inline-block align-top"" />
            Scene-nigma
        </a>
        <div class=""collapse navbar-collapse"" id=""navbarTogglerDemo03"">
            <ul class=""navbar-nav mr-auto mt-2 mt-lg-0"">
                <li class=""nav-item active"">
                    ");
#nullable restore
#line 27 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
               Write(Html.ActionLink("Home", "Index", "Home", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    ");
#nullable restore
#line 30 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
               Write(Html.ActionLink("Movies", "Index", "Movie", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </li>-->\r\n");
                WriteLiteral("        <!--</ul>\r\n                </div>\r\n                <div>\r\n                    <ul class=\"navbar-nav navbar-right\">\r\n                        <li>\r\n                            ");
#nullable restore
#line 40 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Login", "Login", "User", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            ");
#nullable restore
#line 43 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Register", "Register", "User", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </li>
                    </ul>
                </div>
            </nav>
        </div>-->


        <nav class=""navbar navbar-expand-lg navbar-dark bg-dark"">

            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarTogglerDemo03"" aria-controls=""navbarTogglerDemo03"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <a class=""navbar-brand"" href=""/Home/Index"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8df3a3f60fc298bcad2decd29666b60b9c201d4111501", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                Scene-nigma
            </a>

            <div class=""collapse navbar-collapse"" id=""navbarTogglerDemo03"">
                <ul class=""navbar-nav mr-auto mt-2 mt-lg-0"">
                    <li class=""nav-item active"">
                        ");
#nullable restore
#line 64 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Home", "Index", "Home", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
#nullable restore
#line 67 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Movies", "Index", "Movie", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n\r\n            </div>\r\n            <div>\r\n\r\n");
                WriteLiteral("                <ul class=\"navbar-nav navbar-right\">\r\n");
#nullable restore
#line 83 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
                     if (TempData.Peek("CustomerName") != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\r\n                            <p style=\"color:#fff;margin-top:15px;\">Hello ");
#nullable restore
#line 86 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
                                                                    Write(TempData.Peek("CustomerName"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </li>\r\n                        <li>\r\n                            ");
#nullable restore
#line 89 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Profile", "Index", "User", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            ");
#nullable restore
#line 92 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Logout", "Logout", "User", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 94 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\r\n                            ");
#nullable restore
#line 98 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Login", "Login", "User", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            ");
#nullable restore
#line 101 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Register", "Register", "User", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 103 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("                </ul>\r\n\r\n            </div>\r\n\r\n        </nav>\r\n\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 112 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                DefineSection("Scripts", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 114 "C:\DotNet\OnlineMovieTicketBookingApplication-master\OnlineMovieTicketBookingApp\Views\Shared\_Layout.cshtml"
              await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                    WriteLiteral("        ");
                }
                );
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
