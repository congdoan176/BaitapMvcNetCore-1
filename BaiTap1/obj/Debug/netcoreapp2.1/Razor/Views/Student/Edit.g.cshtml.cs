#pragma checksum "C:\Users\admin\source\repos\BaiTap1\BaiTap1\Views\Student\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5fe12b1a1943e74d5546c7eca9c5c7480bb0030"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Edit), @"mvc.1.0.view", @"/Views/Student/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Edit.cshtml", typeof(AspNetCore.Views_Student_Edit))]
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
#line 1 "C:\Users\admin\source\repos\BaiTap1\BaiTap1\Views\_ViewImports.cshtml"
using BaiTap1;

#line default
#line hidden
#line 2 "C:\Users\admin\source\repos\BaiTap1\BaiTap1\Views\_ViewImports.cshtml"
using BaiTap1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5fe12b1a1943e74d5546c7eca9c5c7480bb0030", @"/Views/Student/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb60ea242db9b52ec8106502b377f504a723f5ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BaiTap1.Models.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\admin\source\repos\BaiTap1\BaiTap1\Views\Student\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(74, 15, true);
            WriteLiteral("<h2>Edit</h2>\r\n");
            EndContext();
            BeginContext(89, 654, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1a0097c9a945f7a195347786e02f75", async() => {
                BeginContext(144, 36, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 180, "\"", 197, 1);
#line 8 "C:\Users\admin\source\repos\BaiTap1\BaiTap1\Views\Student\Edit.cshtml"
WriteAttributeValue("", 188, Model.Id, 188, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(198, 168, true);
                WriteLiteral(" />\r\n    <div class=\"input-group\" style=\"margin:20px\">\r\n        <span class=\"glyphicon glyphicon-user input-group-addon\"></span>\r\n        <input type=\"text\" name=\"name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 366, "\"", 385, 1);
#line 11 "C:\Users\admin\source\repos\BaiTap1\BaiTap1\Views\Student\Edit.cshtml"
WriteAttributeValue("", 374, Model.Name, 374, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(386, 208, true);
                WriteLiteral(" class=\"form-control\" />\r\n    </div>\r\n    <div class=\"input-group\" style=\"margin:20px\">\r\n        <span class=\"glyphicon glyphicon-minus input-group-addon\"></span>\r\n        <input type=\"text\" name=\"RollNumber\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 594, "\"", 619, 1);
#line 15 "C:\Users\admin\source\repos\BaiTap1\BaiTap1\Views\Student\Edit.cshtml"
WriteAttributeValue("", 602, Model.RollNumber, 602, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(620, 116, true);
                WriteLiteral(" class=\"form-control\" />\r\n    </div>\r\n    <input type=\"submit\" name=\"submit\" value=\"Submit\" style=\"margin:20px\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(743, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BaiTap1.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591