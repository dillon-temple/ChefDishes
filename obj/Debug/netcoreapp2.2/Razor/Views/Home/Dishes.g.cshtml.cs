#pragma checksum "/Users/momo/Desktop/ChefDishes/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c99173d84a3b1c7e0b4ca27d709a42da80a4447"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
#line 1 "/Users/momo/Desktop/ChefDishes/Views/_ViewImports.cshtml"
using ChefDishes;

#line default
#line hidden
#line 2 "/Users/momo/Desktop/ChefDishes/Views/_ViewImports.cshtml"
using ChefDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c99173d84a3b1c7e0b4ca27d709a42da80a4447", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d1e193f657faf9fe25e69ea403b96cbdb646ae2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/momo/Desktop/ChefDishes/Views/Home/Dishes.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(61, 454, true);
            WriteLiteral(@"
<div class=""top_bar"">
    <a class=""bigbutton"" href=""/"" style=""border-right:3px black solid"">Chefs</a>    <a class=""dishes_button"" href=""""></a>
    <a class=""bigbutton"">Dishes</a>
    <a class=""button"" href=""newDish"">Add a Dish</a>
</div>

<h2 style=""border-bottom: 3px solid black"">Yum! Take a look at our tasty dishes! </h2>

<table class=""chef_table"">
  <tr>
    <th>Name</th>
    <th>Chef</th> 
    <th>Tastiness</th>
    <th>Calories</th>
  </tr>

");
            EndContext();
#line 23 "/Users/momo/Desktop/ChefDishes/Views/Home/Dishes.cshtml"
   foreach(var dish in Model){

#line default
#line hidden
            BeginContext(546, 15, true);
            WriteLiteral("  <tr>\n    <td>");
            EndContext();
            BeginContext(562, 9, false);
#line 25 "/Users/momo/Desktop/ChefDishes/Views/Home/Dishes.cshtml"
   Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(571, 14, true);
            WriteLiteral("</td>\n    <td>");
            EndContext();
            BeginContext(586, 12, false);
#line 26 "/Users/momo/Desktop/ChefDishes/Views/Home/Dishes.cshtml"
   Write(dish.Creator);

#line default
#line hidden
            EndContext();
            BeginContext(598, 15, true);
            WriteLiteral("</td> \n    <td>");
            EndContext();
            BeginContext(614, 14, false);
#line 27 "/Users/momo/Desktop/ChefDishes/Views/Home/Dishes.cshtml"
   Write(dish.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(628, 14, true);
            WriteLiteral("</td>\n    <td>");
            EndContext();
            BeginContext(643, 13, false);
#line 28 "/Users/momo/Desktop/ChefDishes/Views/Home/Dishes.cshtml"
   Write(dish.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(656, 14, true);
            WriteLiteral("</td>\n  </tr>\n");
            EndContext();
#line 30 "/Users/momo/Desktop/ChefDishes/Views/Home/Dishes.cshtml"
  }

#line default
#line hidden
            BeginContext(674, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591