#pragma checksum "C:\Users\nicho\desktop\PokeGotchi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7950bff801b427f8f447cd0834c9d48ba69cd68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\nicho\desktop\PokeGotchi\Views\_ViewImports.cshtml"
using PokeGotchi;

#line default
#line hidden
#line 2 "C:\Users\nicho\desktop\PokeGotchi\Views\_ViewImports.cshtml"
using PokeGotchi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7950bff801b427f8f447cd0834c9d48ba69cd68", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b27eeec2e812847c54d63153f3e300357905ad0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pikachu>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\nicho\desktop\PokeGotchi\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(61, 206, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">PokeGotchi</h1>\r\n    <div class=\"stats\">\r\n        <div class=\"stat\">\r\n            <p>Fullness:</p>\r\n            <progress class=\"nes-progress is-success\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 267, "\"", 290, 1);
#line 10 "C:\Users\nicho\desktop\PokeGotchi\Views\Home\Index.cshtml"
WriteAttributeValue("", 275, Model.Fullness, 275, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(291, 152, true);
            WriteLiteral(" max=\"100\"></progress>\r\n        </div>\r\n        <div class=\"stat\">\r\n            <p>Happiness:</p>\r\n            <progress class=\"nes-progress is-success\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 443, "\"", 467, 1);
#line 14 "C:\Users\nicho\desktop\PokeGotchi\Views\Home\Index.cshtml"
WriteAttributeValue("", 451, Model.Happiness, 451, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(468, 102, true);
            WriteLiteral(" max=\"100\"></progress>\r\n        </div>\r\n        <div class=\"stat\">\r\n            <p>Meals:</p> <br> <p>");
            EndContext();
            BeginContext(571, 11, false);
#line 17 "C:\Users\nicho\desktop\PokeGotchi\Views\Home\Index.cshtml"
                             Write(Model.Meals);

#line default
#line hidden
            EndContext();
            BeginContext(582, 132, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"stat\">\r\n            <p>Energy: </p>\r\n            <progress class=\"nes-progress is-success\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 714, "\"", 735, 1);
#line 21 "C:\Users\nicho\desktop\PokeGotchi\Views\Home\Index.cshtml"
WriteAttributeValue("", 722, Model.Energy, 722, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(736, 66, true);
            WriteLiteral(" max=\"100\"></progress>\r\n        </div>\r\n    </div>\r\n    \r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 802, "\"", 835, 1);
#line 25 "C:\Users\nicho\desktop\PokeGotchi\Views\Home\Index.cshtml"
WriteAttributeValue("", 808, Url.Content(Model.Emotion), 808, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(836, 17, true);
            WriteLiteral(" alt=\"Pikachu\">\r\n");
            EndContext();
#line 26 "C:\Users\nicho\desktop\PokeGotchi\Views\Home\Index.cshtml"
      
        if(Model.isConscious)
        {

#line default
#line hidden
            BeginContext(903, 327, true);
            WriteLiteral(@"            <div class=""buttons"">
                <a href=""Feed"" class=""nes-btn is-primary"">Feed</a>
                <a href=""Play"" class=""nes-btn is-success"">Play</a>
                <a href=""Work"" class=""nes-btn is-error"">Work</a>
                <a href=""Sleep"" class=""nes-btn is-warning"">Sleep</a>
            </div>
");
            EndContext();
#line 35 "C:\Users\nicho\desktop\PokeGotchi\Views\Home\Index.cshtml"
        } else {

#line default
#line hidden
            BeginContext(1248, 124, true);
            WriteLiteral("            <div class=\"buttons\">\r\n                <a href=\"reset\" class=\"nes-btn is-dark\">Restart</a>\r\n            </div>\r\n");
            EndContext();
#line 39 "C:\Users\nicho\desktop\PokeGotchi\Views\Home\Index.cshtml"
        }
    

#line default
#line hidden
            BeginContext(1390, 33, true);
            WriteLiteral("    <div class=\"nes-container\">\r\n");
            EndContext();
#line 42 "C:\Users\nicho\desktop\PokeGotchi\Views\Home\Index.cshtml"
          
            foreach(string s in Model.ActivityLog)
            {

#line default
#line hidden
            BeginContext(1502, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(1522, 1, false);
#line 45 "C:\Users\nicho\desktop\PokeGotchi\Views\Home\Index.cshtml"
              Write(s);

#line default
#line hidden
            EndContext();
            BeginContext(1523, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 46 "C:\Users\nicho\desktop\PokeGotchi\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1555, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pikachu> Html { get; private set; }
    }
}
#pragma warning restore 1591
