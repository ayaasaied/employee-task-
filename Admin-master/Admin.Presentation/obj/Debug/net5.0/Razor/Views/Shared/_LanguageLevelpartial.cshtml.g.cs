#pragma checksum "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\Admin-master\Admin.Presentation\Views\Shared\_LanguageLevelpartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fff5a89b45836c795563cb0acc6008d54eecbc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LanguageLevelpartial), @"mvc.1.0.view", @"/Views/Shared/_LanguageLevelpartial.cshtml")]
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
#line 1 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\Admin-master\Admin.Presentation\Views\_ViewImports.cshtml"
using Admin.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\Admin-master\Admin.Presentation\Views\_ViewImports.cshtml"
using Admin.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\Admin-master\Admin.Presentation\Views\_ViewImports.cshtml"
using Admin.Core.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fff5a89b45836c795563cb0acc6008d54eecbc3", @"/Views/Shared/_LanguageLevelpartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0cd9a02807a616541d036153696f789a5c0f0dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LanguageLevelpartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script>
    $(document).ready(function () {
          $(""#langugeId"").change(function () {
              var lineid=document.getElementById(""langugeId"").value;
              var sid=$(""#langugeId"").val();
              $(""#langaugeslevelids"").empty();

              $.ajax({
                 
                 url: '");
#nullable restore
#line 10 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\Admin-master\Admin.Presentation\Views\Shared\_LanguageLevelpartial.cshtml"
                  Write(Url.Action("LangugelevelId","Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                 type:'Get',
                 dataType:'JSON',
                 data:{""Languofid"":lineid},
                 
                  success: function (resulte) {
                    console.log(""hi1"",resulte)


                   $(""#langaugeslevelids"").append('<option value=""' + ""0"" + '"">' + ""Select Line of Business"" + '</option>');

                     var obj =resulte[""$values""];
                     console.log(obj);
                     
                     for (var item in obj){
                         console.log(""item""+obj[item])
                          $(""#langaugeslevelids"").append('<option value=""' + obj[item].id + '"">' + obj[item].name + '</option>');

                         }

                     
                  },
                  error: function (ex) {
                      console.log(ex);
                      alert('Failed to retrieve data try again.' + ex);
                  }
              });
              
          })
      });
  <");
            WriteLiteral("/script>");
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
