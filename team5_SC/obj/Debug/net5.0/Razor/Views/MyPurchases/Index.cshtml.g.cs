#pragma checksum "C:\Users\Leon (School)\source\repos\lyeow-SA54\team5-ca-sc\team5_SC\Views\MyPurchases\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "181bb171a71fdefb3c37727d907b8927d80e7d74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyPurchases_Index), @"mvc.1.0.view", @"/Views/MyPurchases/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181bb171a71fdefb3c37727d907b8927d80e7d74", @"/Views/MyPurchases/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce34657317260d4fe0e8be08e8225dbef4457c38", @"/Views/_ViewImports.cshtml")]
    public class Views_MyPurchases_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Leon (School)\source\repos\lyeow-SA54\team5-ca-sc\team5_SC\Views\MyPurchases\Index.cshtml"
  
    ViewData["Title"] = "My Purchases";
    List<MyPurchase> purchases = (List<MyPurchase>)ViewData["purchases"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

<div class=""row"" style=""padding: 30px 25px 30px 25px"">

        <div class=""col-sm-4"" style=""padding:15px"">
            <div class=""card text-center"">
                <img class=""card-img-top border"" src=""../../image/Chart.jpg"" alt=""Card image cap"" width=""250"" height=""200"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Product 1</h5>
                    <p class=""card-text"">lorem lorem lorem lorem lorem lorem</p>
                    <a href=""#"" class=""btn btn-primary"">Download</a>
                </div>
            </div>
        </div>

        <div class=""col-sm-8"" style=""padding-top:100px;padding-left:50px"">
            <div class=""row"" style=""padding:10px;"">
                <div class=""col-sm-4"">
                    Product On:
                </div>
                <div class=""col-sm-4"">
                    8 Apr 2019
                </div>
            </div>
            <div class=""row"" style=""padding:10px;"">
                <div class=""col");
            WriteLiteral(@"-sm-4"">
                    Quantity:
                </div>
                <div class=""col-sm-4"">
                    2
                </div>
            </div>
            <div class=""row"" style=""padding:10px;"">
                <div class=""col-sm-4"">
                    Activation Code:
                </div>
                <div class=""col-sm-4"">
                    l1kl1k-1l2kl1-ll12kl-lkjl
                </div>
            </div>
        </div>

</div>


<div class=""row"" style=""padding: 30px 25px 30px 25px"">
    <div class=""col-sm-4"" style=""padding:15px"">
        <div class=""card text-center"">
            <img class=""card-img-top border"" src=""../../image/Loggers.jpg"" alt=""Card image cap"" width=""250"" height=""200"">
            <div class=""card-body"">
                <h5 class=""card-title"">Product 2</h5>
                <p class=""card-text"">Lorem Lorem Lorem Lorem Lorem Lorem</p>
                <a href=""#"" class=""btn btn-primary"">Download</a>
            </div>
        </div");
            WriteLiteral(@">
    </div>

    <div class=""col-sm-8"" style=""padding-top:100px;padding-left:50px"">
            <div class=""row"" style=""padding:10px;"">
                <div class=""col-sm-4"">
                    Product On:
                </div>
                <div class=""col-sm-4"">
                    8 Apr 2019
                </div>
            </div>
            <div class=""row"" style=""padding:10px;"">
                <div class=""col-sm-4"">
                    Quantity:
                </div>
                <div class=""col-sm-4"">
                    2
                </div>
            </div>
            <div class=""row"" style=""padding:10px;"">
                <div class=""col-sm-4"">
                    Activation Code:
                </div>
                <div class=""col-sm-4"">
                    l1kl1k-1l2kl1-ll12kl-lkjl
                </div>
            </div>
        </div>
</div>
");
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