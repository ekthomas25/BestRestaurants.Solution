#pragma checksum "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c04a248b18415cdc8b1efb8e1853ce4e946dcb34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Delete), @"mvc.1.0.view", @"/Views/Cuisines/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c04a248b18415cdc8b1efb8e1853ce4e946dcb34", @"/Views/Cuisines/Delete.cshtml")]
    public class Views_Cuisines_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurants.Models.Cuisine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Are you sure you want to delete this?</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Delete.cshtml"
                                      Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" />\r\n");
#nullable restore
#line 13 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Delete.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Jacob\Desktop\Epicodus\C#_and_.NET\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Delete.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurants.Models.Cuisine> Html { get; private set; }
    }
}
#pragma warning restore 1591
