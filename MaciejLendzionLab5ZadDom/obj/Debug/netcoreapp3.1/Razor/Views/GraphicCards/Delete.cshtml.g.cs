#pragma checksum "C:\Users\Lengom\source\repos\MaciejLendzionLab5ZadDom\MaciejLendzionLab5ZadDom\Views\GraphicCards\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29a8d3d02e4a6e97d7c5a0beee37a2a809b89cb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GraphicCards_Delete), @"mvc.1.0.view", @"/Views/GraphicCards/Delete.cshtml")]
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
#line 1 "C:\Users\Lengom\source\repos\MaciejLendzionLab5ZadDom\MaciejLendzionLab5ZadDom\Views\_ViewImports.cshtml"
using MaciejLendzionLab5ZadDom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lengom\source\repos\MaciejLendzionLab5ZadDom\MaciejLendzionLab5ZadDom\Views\_ViewImports.cshtml"
using MaciejLendzionLab5ZadDom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29a8d3d02e4a6e97d7c5a0beee37a2a809b89cb6", @"/Views/GraphicCards/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ceb8dab85e071a9f6d39258057a1232f3979cdb", @"/Views/_ViewImports.cshtml")]
    public class Views_GraphicCards_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GraphicCard>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!--Potwierdzenie kupna karty, wyświetlamy jej dane i pytamy czy użytkownik potwierdza kupno-->\r\n");
#nullable restore
#line 4 "C:\Users\Lengom\source\repos\MaciejLendzionLab5ZadDom\MaciejLendzionLab5ZadDom\Views\GraphicCards\Delete.cshtml"
 using (Html.BeginForm("Delete", "GraphicCards", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-block\">\r\n    <!--Komunikat-->\r\n    <h4>Do you confirm the purchase?</h4>\r\n    <!--Dane-->\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "C:\Users\Lengom\source\repos\MaciejLendzionLab5ZadDom\MaciejLendzionLab5ZadDom\Views\GraphicCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Producer.ProducerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Lengom\source\repos\MaciejLendzionLab5ZadDom\MaciejLendzionLab5ZadDom\Views\GraphicCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Producer.ProducerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Lengom\source\repos\MaciejLendzionLab5ZadDom\MaciejLendzionLab5ZadDom\Views\GraphicCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Lengom\source\repos\MaciejLendzionLab5ZadDom\MaciejLendzionLab5ZadDom\Views\GraphicCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Lengom\source\repos\MaciejLendzionLab5ZadDom\MaciejLendzionLab5ZadDom\Views\GraphicCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Lengom\source\repos\MaciejLendzionLab5ZadDom\MaciejLendzionLab5ZadDom\Views\GraphicCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n    </dl>\r\n</div>\r\n<!--Przycisk potwierdzenia-->\r\n    <input type=\"submit\" value=\"Kup\" class=\"btn btn-danger\" />\r\n");
#nullable restore
#line 35 "C:\Users\Lengom\source\repos\MaciejLendzionLab5ZadDom\MaciejLendzionLab5ZadDom\Views\GraphicCards\Delete.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GraphicCard> Html { get; private set; }
    }
}
#pragma warning restore 1591