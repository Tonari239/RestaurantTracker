#pragma checksum "C:\Users\Admin\source\repos\RestaurantTracker\RestaurantTracker\Views\Restaurant\GetRestaurant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19e475d169652e4ef7f70d8b3b6126d0ad923ec7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RestaurantTracker.Pages.Restaurant.Views_Restaurant_GetRestaurant), @"mvc.1.0.view", @"/Views/Restaurant/GetRestaurant.cshtml")]
namespace RestaurantTracker.Pages.Restaurant
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
#line 1 "C:\Users\Admin\source\repos\RestaurantTracker\RestaurantTracker\Views\_ViewImports.cshtml"
using RestaurantTracker;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19e475d169652e4ef7f70d8b3b6126d0ad923ec7", @"/Views/Restaurant/GetRestaurant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a53c4f3e7757ab2dde4f5bf8cf3c92f9786bb4", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurant_GetRestaurant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RestaurantTracker.Models.RestaurantViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <span>\r\n        <img id=\"RestaurantPictures\"");
            BeginWriteAttribute("src", " src=\"", 130, "\"", 149, 1);
#nullable restore
#line 6 "C:\Users\Admin\source\repos\RestaurantTracker\RestaurantTracker\Views\Restaurant\GetRestaurant.cshtml"
WriteAttributeValue("", 136, Model.ImgUrl, 136, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <label id=\"imageDate\">Added on ");
#nullable restore
#line 7 "C:\Users\Admin\source\repos\RestaurantTracker\RestaurantTracker\Views\Restaurant\GetRestaurant.cshtml"
                                  Write(Model.DateAdded.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    </span>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19e475d169652e4ef7f70d8b3b6126d0ad923ec73890", async() => {
                WriteLiteral("<em>??????????:</em> ");
#nullable restore
#line 9 "C:\Users\Admin\source\repos\RestaurantTracker\RestaurantTracker\Views\Restaurant\GetRestaurant.cshtml"
                                               Write(Model.Address);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 9 "C:\Users\Admin\source\repos\RestaurantTracker\RestaurantTracker\Views\Restaurant\GetRestaurant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Address);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19e475d169652e4ef7f70d8b3b6126d0ad923ec75659", async() => {
                WriteLiteral("<em>??????????????:</em> ");
#nullable restore
#line 10 "C:\Users\Admin\source\repos\RestaurantTracker\RestaurantTracker\Views\Restaurant\GetRestaurant.cshtml"
                                                   Write(Model.Cleanness);

#line default
#line hidden
#nullable disable
                WriteLiteral("/5");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 10 "C:\Users\Admin\source\repos\RestaurantTracker\RestaurantTracker\Views\Restaurant\GetRestaurant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Cleanness);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19e475d169652e4ef7f70d8b3b6126d0ad923ec77477", async() => {
                WriteLiteral("<em>????????????????????????????:</em> ");
#nullable restore
#line 11 "C:\Users\Admin\source\repos\RestaurantTracker\RestaurantTracker\Views\Restaurant\GetRestaurant.cshtml"
                                                                 Write(Model.HospitalityLevel);

#line default
#line hidden
#nullable disable
                WriteLiteral("/5");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 11 "C:\Users\Admin\source\repos\RestaurantTracker\RestaurantTracker\Views\Restaurant\GetRestaurant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.HospitalityLevel);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19e475d169652e4ef7f70d8b3b6126d0ad923ec79330", async() => {
                WriteLiteral("<em>?????? ???????????????? ??????????:</em>: ");
#nullable restore
#line 12 "C:\Users\Admin\source\repos\RestaurantTracker\RestaurantTracker\Views\Restaurant\GetRestaurant.cshtml"
                                                                    Write(Model.VeganFriendly == true ? "????":"????");

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 12 "C:\Users\Admin\source\repos\RestaurantTracker\RestaurantTracker\Views\Restaurant\GetRestaurant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.VeganFriendly);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19e475d169652e4ef7f70d8b3b6126d0ad923ec711168", async() => {
                WriteLiteral("<em>?????????????????? ???? ???????????????? ????????????????:</em> ");
#nullable restore
#line 13 "C:\Users\Admin\source\repos\RestaurantTracker\RestaurantTracker\Views\Restaurant\GetRestaurant.cshtml"
                                                                            Write(Model.FreeToilet == true ? "????":"????");

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 13 "C:\Users\Admin\source\repos\RestaurantTracker\RestaurantTracker\Views\Restaurant\GetRestaurant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FreeToilet);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19e475d169652e4ef7f70d8b3b6126d0ad923ec713020", async() => {
                WriteLiteral("<em>?????????? ???? ?????????????? ??????????????:</em> ");
#nullable restore
#line 14 "C:\Users\Admin\source\repos\RestaurantTracker\RestaurantTracker\Views\Restaurant\GetRestaurant.cshtml"
                                                                       Write(Model.PetFriendly == true ? "????":"????");

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 14 "C:\Users\Admin\source\repos\RestaurantTracker\RestaurantTracker\Views\Restaurant\GetRestaurant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.PetFriendly);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" <br />


</div>








<style>
    #RestaurantPictures {
        width: 200px;
        height: 200px;
        display: block;
        padding-bottom: 5px;
        position: absolute;
        right: 50%;
    }

    #imageDate {
        position: absolute;
        right: 50%;
        top: 50%;
        color: slategray;
    }

    #objectDiv {
        max-width: 250px;
    }

    .border-1 {
        border-color: lightgray;
        border-style: solid;
        padding-top: 5px;
        margin-bottom: 5px;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantTracker.Models.RestaurantViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
