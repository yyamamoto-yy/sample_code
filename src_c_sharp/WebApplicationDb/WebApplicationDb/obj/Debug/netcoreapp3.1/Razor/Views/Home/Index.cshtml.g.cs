#pragma checksum "C:\Users\anvil\source\repos\WebApplicationDb\WebApplicationDb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "147b11eff36bc2918c244c7f929a5ec2ddcfeae0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\anvil\source\repos\WebApplicationDb\WebApplicationDb\Views\_ViewImports.cshtml"
using WebApplicationDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anvil\source\repos\WebApplicationDb\WebApplicationDb\Views\_ViewImports.cshtml"
using WebApplicationDb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147b11eff36bc2918c244c7f929a5ec2ddcfeae0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cee62c835436602a1ad8748145cc555ad9e00a40", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplicationDb.Models.List>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\anvil\source\repos\WebApplicationDb\WebApplicationDb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n    <div class=\"alert alert-success\">\r\n        id: ");
#nullable restore
#line 9 "C:\Users\anvil\source\repos\WebApplicationDb\WebApplicationDb\Views\Home\Index.cshtml"
       Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        name: ");
#nullable restore
#line 10 "C:\Users\anvil\source\repos\WebApplicationDb\WebApplicationDb\Views\Home\Index.cshtml"
         Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplicationDb.Models.List> Html { get; private set; }
    }
}
#pragma warning restore 1591
