#pragma checksum "C:\Users\meti-\Desktop\Integrirani Sistemi\HotelProject\HotelSystemApplication\HotelSystem.Web\Views\ReservationCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10f89cd5258ee65c057a11f3fa3ce0e89f345c74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReservationCart_Index), @"mvc.1.0.view", @"/Views/ReservationCart/Index.cshtml")]
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
#line 1 "C:\Users\meti-\Desktop\Integrirani Sistemi\HotelProject\HotelSystemApplication\HotelSystem.Web\Views\_ViewImports.cshtml"
using HotelSystem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\meti-\Desktop\Integrirani Sistemi\HotelProject\HotelSystemApplication\HotelSystem.Web\Views\_ViewImports.cshtml"
using HotelSystem.Domain.DomainModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10f89cd5258ee65c057a11f3fa3ce0e89f345c74", @"/Views/ReservationCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f167909f68ead7b4ed2684464486327d9badd217", @"/Views/_ViewImports.cshtml")]
    public class Views_ReservationCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelSystem.Domain.DTO.HotelCartDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderNow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ReservationCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteHotelFromReservationCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <div class=\"row m-5\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10f89cd5258ee65c057a11f3fa3ce0e89f345c745009", async() => {
                WriteLiteral("Order Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

    <div class=""row m-5"">
        <table class=""table"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Hotel Name</th>
                    <th scope=""col"">Hotel Price</th>
                    <th scope=""col"">Stars</th>
                    <th scope=""col"">Check In Date</th>
                    <th scope=""col"">Check Out Date</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 23 "C:\Users\meti-\Desktop\Integrirani Sistemi\HotelProject\HotelSystemApplication\HotelSystem.Web\Views\ReservationCart\Index.cshtml"
                 for (int i = 0; i < Model.HotelInReservationCarts.Count; i++)
                {
                    var item = Model.HotelInReservationCarts[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 27 "C:\Users\meti-\Desktop\Integrirani Sistemi\HotelProject\HotelSystemApplication\HotelSystem.Web\Views\ReservationCart\Index.cshtml"
                                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\meti-\Desktop\Integrirani Sistemi\HotelProject\HotelSystemApplication\HotelSystem.Web\Views\ReservationCart\Index.cshtml"
                       Write(item.Hotel.HotelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\meti-\Desktop\Integrirani Sistemi\HotelProject\HotelSystemApplication\HotelSystem.Web\Views\ReservationCart\Index.cshtml"
                       Write(item.Hotel.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\meti-\Desktop\Integrirani Sistemi\HotelProject\HotelSystemApplication\HotelSystem.Web\Views\ReservationCart\Index.cshtml"
                       Write(item.Hotel.Stars);

#line default
#line hidden
#nullable disable
            WriteLiteral(" *</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\meti-\Desktop\Integrirani Sistemi\HotelProject\HotelSystemApplication\HotelSystem.Web\Views\ReservationCart\Index.cshtml"
                       Write(item.checkIn.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\meti-\Desktop\Integrirani Sistemi\HotelProject\HotelSystemApplication\HotelSystem.Web\Views\ReservationCart\Index.cshtml"
                       Write(item.checkout.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10f89cd5258ee65c057a11f3fa3ce0e89f345c749298", async() => {
                WriteLiteral("Delete Reservation");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-hotelid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\meti-\Desktop\Integrirani Sistemi\HotelProject\HotelSystemApplication\HotelSystem.Web\Views\ReservationCart\Index.cshtml"
                                                                       WriteLiteral(item.Hotel.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hotelid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-hotelid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hotelid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 36 "C:\Users\meti-\Desktop\Integrirani Sistemi\HotelProject\HotelSystemApplication\HotelSystem.Web\Views\ReservationCart\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n            <tfoot>\r\n                <tr>\r\n                    <th scope=\"col\">Total Price: </th>\r\n                    <th scope=\"col\"></th>\r\n                    <th scope=\"col\">");
#nullable restore
#line 42 "C:\Users\meti-\Desktop\Integrirani Sistemi\HotelProject\HotelSystemApplication\HotelSystem.Web\Views\ReservationCart\Index.cshtml"
                               Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</th>\r\n                </tr>\r\n            </tfoot>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelSystem.Domain.DTO.HotelCartDto> Html { get; private set; }
    }
}
#pragma warning restore 1591