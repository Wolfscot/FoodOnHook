#pragma checksum "D:\SOFTUNI\C Web Developer\c#Web\Project second try\FoodOnHook\FoodOnHook\Views\Restaurant\RestaurantOwner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "534609f739038bf22b02014198e960b9e969d217"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurant_RestaurantOwner), @"mvc.1.0.view", @"/Views/Restaurant/RestaurantOwner.cshtml")]
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
#line 1 "D:\SOFTUNI\C Web Developer\c#Web\Project second try\FoodOnHook\FoodOnHook\Views\_ViewImports.cshtml"
using FoodOnHook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SOFTUNI\C Web Developer\c#Web\Project second try\FoodOnHook\FoodOnHook\Views\_ViewImports.cshtml"
using FoodOnHook.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SOFTUNI\C Web Developer\c#Web\Project second try\FoodOnHook\FoodOnHook\Views\_ViewImports.cshtml"
using FoodOnHook.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SOFTUNI\C Web Developer\c#Web\Project second try\FoodOnHook\FoodOnHook\Views\_ViewImports.cshtml"
using FoodOnHook.Models.Dish;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SOFTUNI\C Web Developer\c#Web\Project second try\FoodOnHook\FoodOnHook\Views\_ViewImports.cshtml"
using FoodOnHook.Models.Category;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"534609f739038bf22b02014198e960b9e969d217", @"/Views/Restaurant/RestaurantOwner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29e1975372d88f0a70972c2e98376b81b30f364", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurant_RestaurantOwner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "534609f739038bf22b02014198e960b9e969d2174590", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""form-group first"">
                <label for=""fname"">First Name</label>
                <input type=""text"" class=""form-control"" placeholder=""e.g. John"" id=""fname"">
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""form-group first"">
                <label for=""lname"">Last Name</label>
                <input type=""text"" class=""form-control"" placeholder=""e.g. Smith"" id=""lname"">
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""form-group first"">
                <label for=""email"">Email Address</label>
                <input type=""email"" class=""form-control"" placeholder=""e.g. john@your-domain.com"" id=""email"">
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""form-group first"">
                <label for=""lname"">Phone Number</lab");
                WriteLiteral(@"el>
                <input type=""text"" class=""form-control"" placeholder=""+00 0000 000 0000"" id=""lname"">
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""form-group first"">
                <label for=""lname"">Website</label>
                <input type=""text"" class=""form-control"" placeholder=""e.g. https://google.com"" id=""lname"">
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-6"">

            <div class=""form-group last mb-3"">
                <label for=""password"">Password</label>
                <input type=""password"" class=""form-control"" placeholder=""Your Password"" id=""password"">
            </div>
        </div>
        <div class=""col-md-6"">

            <div class=""form-group last mb-3"">
                <label for=""re-password"">Re-type Password</label>
                <input type=""password"" class=""form-control"" placeholder=""Your Password"" id=""re-password"">
            </div>
        </div>
    </");
                WriteLiteral(@"div>

    <div class=""d-flex mb-5 mt-4 align-items-center"">
        <div class=""d-flex align-items-center"">
            <label class=""control control--checkbox mb-0"">
                <span class=""caption"">Creating an account means you're okay with our <a href=""#"">Terms and Conditions</a> and our <a href=""#"">Privacy Policy</a>.</span>
                <input type=""checkbox"" checked=""checked"" />
                <div class=""control__indicator""></div>
            </label>
        </div>
    </div>

    <input type=""submit"" value=""Register"" class=""btn px-5 btn-primary"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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