#pragma checksum "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed000108dfa8d640b68c919cb7bb656cc7455d39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Edit), @"mvc.1.0.view", @"/Views/Cuisines/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed000108dfa8d640b68c919cb7bb656cc7455d39", @"/Views/Cuisines/Edit.cshtml")]
    public class Views_Cuisines_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurants.Models.Cuisine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Edit this Cuisine: ");
#nullable restore
#line 5 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Edit.cshtml"
                  Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Edit.cshtml"
Write(Html.HiddenFor(model => model.CuisineId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Edit.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Edit.cshtml"
Write(Html.EditorFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Edit\" class=\"btn btn-dark\" />\r\n");
#nullable restore
#line 18 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 19 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Edit.cshtml"
Write(Html.ActionLink("Back to list of cuisines", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 20 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Edit.cshtml"
Write(Html.ActionLink("Edit Cuisine", "Edit", new { id = Model.CuisineId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
