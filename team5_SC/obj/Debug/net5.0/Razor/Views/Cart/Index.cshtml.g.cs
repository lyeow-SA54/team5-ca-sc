#pragma checksum "C:\Users\Leon (School)\source\repos\lyeow-SA54\team5-ca-sc\team5_SC\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41c65206850d789db2110470d53263a33a958a0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\Leon (School)\source\repos\lyeow-SA54\team5-ca-sc\team5_SC\Views\_ViewImports.cshtml"
using team5_SC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Leon (School)\source\repos\lyeow-SA54\team5-ca-sc\team5_SC\Views\_ViewImports.cshtml"
using team5_SC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41c65206850d789db2110470d53263a33a958a0a", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce34657317260d4fe0e8be08e8225dbef4457c38", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Leon (School)\source\repos\lyeow-SA54\team5-ca-sc\team5_SC\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "My Cart";

    List<Cart> carts = ViewBag.cartDetails;
    List<Product> products = ViewBag.products;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\" style=\"padding: 30px 25px 30px 25px\">\r\n");
#nullable restore
#line 12 "C:\Users\Leon (School)\source\repos\lyeow-SA54\team5-ca-sc\team5_SC\Views\Cart\Index.cshtml"
         foreach (Cart cart in carts)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-sm-4"" style=""padding:15px"">
                <div class=""card text-center"">
                    <img class=""card-img-top border"" src=# alt=""Card image cap"" width=""250"" height=""200"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">");
#nullable restore
#line 18 "C:\Users\Leon (School)\source\repos\lyeow-SA54\team5-ca-sc\team5_SC\Views\Cart\Index.cshtml"
                                          Write(cart.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
            WriteLiteral("</p>\r\n                        <a href=\"#\" class=\"btn btn-primary\">Download</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""col-sm-8"" style=""padding-top:100px;padding-left:50px"">
                
                <div class=""row"" style=""padding:10px;"">
                    <div class=""col-sm-4"">
                        Quantity:
                    </div>
                    <div class=""col-sm-4"">");
#nullable restore
#line 31 "C:\Users\Leon (School)\source\repos\lyeow-SA54\team5-ca-sc\team5_SC\Views\Cart\Index.cshtml"
                                     Write(cart.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 34 "C:\Users\Leon (School)\source\repos\lyeow-SA54\team5-ca-sc\team5_SC\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
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