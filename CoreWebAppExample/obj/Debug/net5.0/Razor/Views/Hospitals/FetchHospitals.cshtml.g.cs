#pragma checksum "C:\Users\OHMLAP-0143\source\repos\CoreWebAppExample\CoreWebAppExample\Views\Hospitals\FetchHospitals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cca9c06fe44fe3f56a762868342d86515fcab11b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hospitals_FetchHospitals), @"mvc.1.0.view", @"/Views/Hospitals/FetchHospitals.cshtml")]
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
#line 1 "C:\Users\OHMLAP-0143\source\repos\CoreWebAppExample\CoreWebAppExample\Views\_ViewImports.cshtml"
using CoreWebAppExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OHMLAP-0143\source\repos\CoreWebAppExample\CoreWebAppExample\Views\_ViewImports.cshtml"
using CoreWebAppExample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cca9c06fe44fe3f56a762868342d86515fcab11b", @"/Views/Hospitals/FetchHospitals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f17d9200b246195f060685c4a06415185af4c3f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Hospitals_FetchHospitals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreWebAppExample.Models.Hospital>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\OHMLAP-0143\source\repos\CoreWebAppExample\CoreWebAppExample\Views\Hospitals\FetchHospitals.cshtml"
 using(Html.BeginForm()) { 
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\OHMLAP-0143\source\repos\CoreWebAppExample\CoreWebAppExample\Views\Hospitals\FetchHospitals.cshtml"
Write(Html.EditorForModel());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 6 "C:\Users\OHMLAP-0143\source\repos\CoreWebAppExample\CoreWebAppExample\Views\Hospitals\FetchHospitals.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 8 "C:\Users\OHMLAP-0143\source\repos\CoreWebAppExample\CoreWebAppExample\Views\Hospitals\FetchHospitals.cshtml"
Write(ViewBag.Display);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreWebAppExample.Models.Hospital>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
