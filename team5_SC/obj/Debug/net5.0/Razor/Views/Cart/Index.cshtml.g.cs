#pragma checksum "C:\Users\Ang\source\repos\team5-ca-sc\team5_SC\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2d163371b5a1ee579ec4689ffcb9646d7cf6980"
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
#line 1 "C:\Users\Ang\source\repos\team5-ca-sc\team5_SC\Views\_ViewImports.cshtml"
using team5_SC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ang\source\repos\team5-ca-sc\team5_SC\Views\_ViewImports.cshtml"
using team5_SC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d163371b5a1ee579ec4689ffcb9646d7cf6980", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce34657317260d4fe0e8be08e8225dbef4457c38", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Ang\source\repos\team5-ca-sc\team5_SC\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart";
    List<Cart> carts = (List<Cart>)ViewData["carts"];
    int userCartQty = (int)ViewData["userCartQty"];

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ang\source\repos\team5-ca-sc\team5_SC\Views\Cart\Index.cshtml"
 foreach (Cart cart in carts)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\" style=\"padding: 30px 25px 30px 25px\">\r\n\r\n        <div class=\"col-sm-4\" style=\"padding:15px\">\r\n            <div class=\"card text-center\">\r\n                <img class=\"card-img-top border\"");
            BeginWriteAttribute("src", " src=", 1553, "", 1577, 1);
#nullable restore
#line 39 "C:\Users\Ang\source\repos\team5-ca-sc\team5_SC\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1558, cart.Product.Image, 1558, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" width=\"250\" height=\"200\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 41 "C:\Users\Ang\source\repos\team5-ca-sc\team5_SC\Views\Cart\Index.cshtml"
                                      Write(cart.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 42 "C:\Users\Ang\source\repos\team5-ca-sc\team5_SC\Views\Cart\Index.cshtml"
                                    Write(cart.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    
                </div>
            </div>
        </div>

        <div class=""col-sm-8"" style=""padding-top:100px;padding-left:50px"">
            <div class=""row"" style=""padding:10px;"">
                <div class=""col-sm-4"">
                    <div class=""a_price"">Price: </div>   <div class=""a_price_num"">$ ");
#nullable restore
#line 51 "C:\Users\Ang\source\repos\team5-ca-sc\team5_SC\Views\Cart\Index.cshtml"
                                                                               Write(cart.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                </div>\r\n                <div class=\"a_cartDetailqty\">\r\n                    <div class=\"a_quantity\">Quantity: </div>\r\n                    <a");
            BeginWriteAttribute("id", " id=", 2327, "", 2347, 1);
#nullable restore
#line 55 "C:\Users\Ang\source\repos\team5-ca-sc\team5_SC\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2331, cart.Product.Id, 2331, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"a_quantity_num\">\r\n                        <div class=\"count_d\">-</div>\r\n\r\n                        <input id=\"cart_quanaity\" class=\"num_count\"");
            BeginWriteAttribute("value", " value=\"", 2496, "\"", 2518, 1);
#nullable restore
#line 58 "C:\Users\Ang\source\repos\team5-ca-sc\team5_SC\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2504, cart.Quantity, 2504, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <div class=\"count_i\">+</div>\r\n                        <a href=\"#\" class=\"btn btn-primary\">Delete </a>\r\n                </div>\r\n            </div>\r\n            \r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 67 "C:\Users\Ang\source\repos\team5-ca-sc\team5_SC\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
