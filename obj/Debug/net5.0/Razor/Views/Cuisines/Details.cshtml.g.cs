#pragma checksum "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6394fb6b82725ec303732179765c4e5d3a110854"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Details), @"mvc.1.0.view", @"/Views/Cuisines/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6394fb6b82725ec303732179765c4e5d3a110854", @"/Views/Cuisines/Details.cshtml")]
    public class Views_Cuisines_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurants.Models.Cuisine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Cuisine Details</h2>\r\n<hr />\r\n<h3>");
#nullable restore
#line 8 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 8 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>");
#nullable restore
#line 9 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<p>");
#nullable restore
#line 10 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
Write(Html.ActionLink("Edit Cuisine", "Edit", new { id = Model.CuisineId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 11 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
Write(Html.ActionLink("Delete Cuisine", "Delete", new { id = Model.CuisineId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 12 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
Write(Html.ActionLink("Back to list of cuisines", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurants.Models.Cuisine> Html { get; private set; }
    }
}
#pragma warning restore 1591