#pragma checksum "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9d25fa66ea6fcaf7dd0e3374af73d1240aef2da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Edit), @"mvc.1.0.view", @"/Views/Restaurants/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9d25fa66ea6fcaf7dd0e3374af73d1240aef2da", @"/Views/Restaurants/Edit.cshtml")]
    public class Views_Restaurants_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurants.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Edit: ");
#nullable restore
#line 9 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Edit.cshtml"
     Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Edit.cshtml"
Write(Html.HiddenFor(model => model.RestaurantId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Edit.cshtml"
Write(Html.TextBoxFor(model => model.Name,
new {required="required"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Edit.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Edit.cshtml"
Write(Html.TextBoxFor(model => model.Description,
new {required="required"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Edit.cshtml"
Write(Html.LabelFor(model => model.Cuisine));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Edit.cshtml"
Write(Html.DropDownList("CuisineId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" class=\"btn btn-dark\" />\r\n");
#nullable restore
#line 27 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 29 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurants.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
