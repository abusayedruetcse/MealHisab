#pragma checksum "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Administration\Language\LanguageIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d4ceed56c424cd16cc895deb1d0333b7fc84dac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Administration_Language_LanguageIndex), @"mvc.1.0.view", @"/Modules/Administration/Language/LanguageIndex.cshtml")]
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
#line 1 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\_ViewImports.cshtml"
using MealHisab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d4ceed56c424cd16cc895deb1d0333b7fc84dac", @"/Modules/Administration/Language/LanguageIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8602ea686e52cb9df8888bbf826dc27189c74926", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Administration_Language_LanguageIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Administration\Language\LanguageIndex.cshtml"
  
    ViewData["Title"] = Localizer.Get("Db.Administration.Language.EntityPlural");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"GridDiv\"></div>\r\n\r\n<script type=\"text/javascript\">\r\n    jQuery(function () {\r\n        new MealHisab.Administration.LanguageGrid($(\'#GridDiv\'), {}).init();\r\n\r\n        Q.initFullHeightGridPage($(\'#GridDiv\'));\r\n    });\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
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
