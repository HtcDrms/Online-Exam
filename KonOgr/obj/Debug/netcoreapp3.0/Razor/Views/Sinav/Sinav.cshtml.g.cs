#pragma checksum "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d0ae534523135a84ddde3bcd91aa9c419918aed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sinav_Sinav), @"mvc.1.0.view", @"/Views/Sinav/Sinav.cshtml")]
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
#line 1 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\_ViewImports.cshtml"
using KonOgr;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\_ViewImports.cshtml"
using KonOgr.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0ae534523135a84ddde3bcd91aa9c419918aed", @"/Views/Sinav/Sinav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d580d1f5a613b974eb06b545f0e47e7d3466f6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Sinav_Sinav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
  
    ViewData["Title"] = "Sinav";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"sinav\" class=\"container\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
      
        var baslik = ViewBag.baslik;
        var yazi = ViewBag.yazi;
        var sorular = ViewBag.sorular;
        var cevaplar = ViewBag.cevaplar;
        var dogrucevaplar = ViewBag.dogrucevaplar;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d0ae534523135a84ddde3bcd91aa9c419918aed3874", async() => {
                WriteLiteral("\r\n        <div class=\"form-group row col-md-12\">\r\n\r\n            <h4 class=\"m-auto\">");
#nullable restore
#line 19 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                          Write(baslik);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n\r\n\r\n        </div>\r\n        <div class=\"form-group row col-md-12\">\r\n            <div class=\"col-md-12\">\r\n                <p>");
#nullable restore
#line 25 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
              Write(yazi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n        <div class=\"form-group row col-md-12\">\r\n\r\n            <div id=\"soru1\" class=\"col-md-6\">\r\n                <p style=\"word-wrap:break-word;\">1-) ");
#nullable restore
#line 34 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                Write(sorular[0]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <input type=\"radio\" value=\"a\" id=\"cevap1a\" name=\"cevap1\">\r\n                <label class=\"label\" id=\"label1a\" name=\"label1\" for=\"cevap1a\">A-) ");
#nullable restore
#line 36 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                                             Write(cevaplar[0]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br />\r\n                <input type=\"radio\" value=\"b\" id=\"cevap1b\" name=\"cevap1\">\r\n                <label id=\"label1b\" name=\"label1\" for=\"cevap1b\">B-) ");
#nullable restore
#line 38 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                               Write(cevaplar[1]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br />\r\n                <input type=\"radio\" value=\"c\" id=\"cevap1c\" name=\"cevap1\">\r\n                <label id=\"label1c\" name=\"label1\" for=\"cevap1c\">C-) ");
#nullable restore
#line 40 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                               Write(cevaplar[2]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <br />\r\n                <input type=\"radio\" value=\"d\" id=\"cevap1d\" name=\"cevap1\">\r\n                <label id=\"label1d\" name=\"label1\" for=\"cevap1d\">D-) ");
#nullable restore
#line 42 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                               Write(cevaplar[3]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n            <div id=\"soru2\" class=\"col-md-6\">\r\n                <p style=\"word-wrap:break-word;\">2-) ");
#nullable restore
#line 45 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                Write(sorular[1]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <input type=\"radio\" value=\"a\" id=\"cevap2a\" name=\"cevap2\">\r\n                <label id=\"label2a\" name=\"label2\" for=\"cevap2a\">A-) ");
#nullable restore
#line 47 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                               Write(cevaplar[4]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br />\r\n                <input type=\"radio\" value=\"b\" id=\"cevap2b\" name=\"cevap2\">\r\n                <label id=\"label2b\" name=\"label2\" for=\"cevap2b\">B-) ");
#nullable restore
#line 49 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                               Write(cevaplar[5]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br />\r\n                <input type=\"radio\" value=\"c\" id=\"cevap2c\" name=\"cevap2\">\r\n                <label id=\"label2c\" name=\"label2\" for=\"cevap2c\">C-) ");
#nullable restore
#line 51 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                               Write(cevaplar[6]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <br />\r\n                <input type=\"radio\" value=\"d\" id=\"cevap2d\" name=\"cevap2\">\r\n                <label id=\"label2d\" name=\"label2\" for=\"cevap2d\">D-) ");
#nullable restore
#line 53 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                               Write(cevaplar[7]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n\r\n\r\n        </div>\r\n        <div class=\"form-group row col-md-12\">\r\n\r\n            <div id=\"soru3\" class=\"col-md-6\">\r\n                <p style=\"word-wrap:break-word;\">3-) ");
#nullable restore
#line 61 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                Write(sorular[2]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <input type=\"radio\" value=\"a\" id=\"cevap3a\" name=\"cevap3\">\r\n                <label id=\"label3a\" name=\"label3\" for=\"cevap3a\">A-) ");
#nullable restore
#line 63 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                               Write(cevaplar[8]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br />\r\n                <input type=\"radio\" value=\"b\" id=\"cevap3b\" name=\"cevap3\">\r\n                <label id=\"label3b\" name=\"label3\" for=\"cevap3b\">B-) ");
#nullable restore
#line 65 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                               Write(cevaplar[9]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br />\r\n                <input type=\"radio\" value=\"c\" id=\"cevap3c\" name=\"cevap3\">\r\n                <label id=\"label3c\" name=\"label3\" for=\"cevap3c\">C-) ");
#nullable restore
#line 67 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                               Write(cevaplar[10]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <br />\r\n                <input type=\"radio\" value=\"d\" id=\"cevap3d\" name=\"cevap3\">\r\n                <label id=\"label3d\" name=\"label3\" for=\"cevap3d\">D-) ");
#nullable restore
#line 69 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                               Write(cevaplar[11]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n            <div id=\"soru4\" class=\"col-md-6\">\r\n                <p style=\"word-wrap:break-word;\">4-) ");
#nullable restore
#line 72 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                Write(sorular[3]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <input type=\"radio\" value=\"a\" id=\"cevap4a\" name=\"cevap4\">\r\n                <label id=\"label4a\" name=\"label4\" for=\"cevap4a\">A-) ");
#nullable restore
#line 74 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                               Write(cevaplar[12]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br />\r\n                <input type=\"radio\" value=\"b\" id=\"cevap4b\" name=\"cevap4\">\r\n                <label id=\"label4b\" name=\"label4\" for=\"cevap4b\">B-) ");
#nullable restore
#line 76 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                               Write(cevaplar[13]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br />\r\n                <input type=\"radio\" value=\"c\" id=\"cevap4c\" name=\"cevap4\">\r\n                <label id=\"label4c\" name=\"label4\" for=\"cevap4c\">C-) ");
#nullable restore
#line 78 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                               Write(cevaplar[14]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <br />\r\n                <input type=\"radio\" value=\"d\" id=\"cevap4d\" name=\"cevap4\">\r\n                <label id=\"label4d\" name=\"label4\" for=\"cevap4d\">D-) ");
#nullable restore
#line 80 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                                                               Write(cevaplar[15]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n        <div class=\"text-center\">\r\n            <button type=\"button\" onclick=\"kontrol()\" class=\"btn btn-primary\">Sınavı Tamamla</button>\r\n        </div>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<script type=""text/javascript"">
    $(document).ready(function () {
        $(""label"").click(function () {
            var name = $(this).attr('name');



            $(""label[name='"" + name + ""']"").removeAttr(""class"");
            $(this).addClass('secim');


        });

    });


    function kontrol() {
        var dogrucevap = new Array();
        dogrucevap[0] = '");
#nullable restore
#line 111 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                    Write(dogrucevaplar[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        dogrucevap[1] = \'");
#nullable restore
#line 112 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                    Write(dogrucevaplar[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        dogrucevap[2] = \'");
#nullable restore
#line 113 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                    Write(dogrucevaplar[2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        dogrucevap[3] = \'");
#nullable restore
#line 114 "C:\Users\SoftwareEng\Source\Repos\KonOgr\KonOgr\Views\Sinav\Sinav.cshtml"
                    Write(dogrucevaplar[3]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

        var cevap1 = document.getElementsByName('cevap1');
        var cevap2 = document.getElementsByName('cevap2');
        var cevap3 = document.getElementsByName('cevap3');
        var cevap4 = document.getElementsByName('cevap4');

        $(""label"").removeAttr(""class"");

        for (var i = 0, length = 4; i < length; i++) {
            if (cevap1[i].checked) {
                var kontrol1 = cevap1[i].value;
                if (kontrol1 == dogrucevap[0])
                    $(""label[id='label1"" + kontrol1 + ""']"").addClass(""dogru"");
                else
                    $(""label[id='label1"" + kontrol1 + ""']"").addClass(""yanlis"");
            }
            if (cevap2[i].checked) {
                var kontrol2 = cevap2[i].value;
                if (kontrol2 == dogrucevap[1])
                    $(""label[id='label2"" + kontrol2 + ""']"").addClass(""dogru"");
                else
                    $(""label[id='label2"" + kontrol2 + ""']"").addClass(""yanlis"");
            }
           ");
            WriteLiteral(@" if (cevap3[i].checked) {
                var kontrol3 = cevap3[i].value;
                if (kontrol3 == dogrucevap[2])
                    $(""label[id='label3"" + kontrol3 + ""']"").addClass(""dogru"");
                else
                    $(""label[id='label3"" + kontrol3 + ""']"").addClass(""yanlis"");
            }
            if (cevap4[i].checked) {
                var kontrol4 = cevap4[i].value;
                if (kontrol4 == dogrucevap[3])
                    $(""label[id='label4"" + kontrol4 + ""']"").addClass(""dogru"");
                else
                    $(""label[id='label4"" + kontrol4 + ""']"").addClass(""yanlis"");
            }

        }


    }
</script>


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
