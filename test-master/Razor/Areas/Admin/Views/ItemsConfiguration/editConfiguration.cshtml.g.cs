#pragma checksum "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\editConfiguration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7566d4a4f54ea0e5fe6fad1b0524c46167b4fc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ItemsConfiguration_editConfiguration), @"mvc.1.0.view", @"/Areas/Admin/Views/ItemsConfiguration/editConfiguration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ItemsConfiguration/editConfiguration.cshtml", typeof(AspNetCore.Areas_Admin_Views_ItemsConfiguration_editConfiguration))]
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
#line 8 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\editConfiguration.cshtml"
using project_banhang.Models;

#line default
#line hidden
#line 10 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\editConfiguration.cshtml"
using System.Text;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7566d4a4f54ea0e5fe6fad1b0524c46167b4fc1", @"/Areas/Admin/Views/ItemsConfiguration/editConfiguration.cshtml")]
    public class Areas_Admin_Views_ItemsConfiguration_editConfiguration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\editConfiguration.cshtml"
  
    ViewData["Title"] = "editConfiguration";
    Layout = "~/Areas/Admin/Views/_share/_layout.cshtml";

#line default
#line hidden
            BeginContext(114, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(256, 247, true);
            WriteLiteral("\r\n\r\n<article class=\"content item-editor-page\">\r\n    <div class=\"title-block\">\r\n        <h3 class=\"title\">\r\n            Add new item <span class=\"sparkline bar\" data-type=\"bar\"></span>\r\n        </h3>\r\n    </div>\r\n    <form name=\"item\" method=\"post\"");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 503, "\"", 531, 1);
#line 19 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\editConfiguration.cshtml"
WriteAttributeValue("", 512, ViewBag.FormAction, 512, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(532, 33, true);
            WriteLiteral(" enctype=\"multipart/form-data\">\r\n");
            EndContext();
            BeginContext(639, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(648, 23, false);
#line 21 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\editConfiguration.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(671, 349, true);
            WriteLiteral(@"
        <div class=""card card-block"">
            <!--row-->
            <div class=""form-group row"">
                <label class=""col-sm-2 form-control-label text-xs-right""> Tên sản phẩm: </label>
                <div class=""col-sm-5"">
                    <input type=""text"" class=""form-control boxed"" placeholder=""Tên sản phẩm"" name=""name""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1020, "\"", 1088, 1);
            WriteAttributeValue("", 1028, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#line 27 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\editConfiguration.cshtml"
                                                                                                                 if (Model != null) {

#line default
#line hidden
                BeginContext(1056, 24, false);
#line 27 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\editConfiguration.cshtml"
                                                                                                                                      Write(ViewBag.nameProduct.name);

#line default
#line hidden
                EndContext();
#line 27 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\editConfiguration.cshtml"
                                                                                                                                                                           }

#line default
#line hidden
                PopWriter();
            }
            ), 1028, 60, false);
            EndWriteAttribute();
            BeginContext(1089, 391, true);
            WriteLiteral(@" readonly>
                </div>
            </div>
            <!--row-->
            <!--end row-->
            <div class=""form-group row"">
                <label class=""col-sm-2 form-control-label text-xs-right""> Thương hiệu: </label>
                <div class=""col-sm-5"">
                    <input type=""text"" class=""form-control boxed"" placeholder=""Thương hiệu"" name=""brand""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1480, "\"", 1535, 1);
            WriteAttributeValue("", 1488, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#line 35 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\editConfiguration.cshtml"
                                                                                                                 if (Model != null) {

#line default
#line hidden
                BeginContext(1516, 11, false);
#line 35 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\editConfiguration.cshtml"
                                                                                                                                      Write(Model.brand);

#line default
#line hidden
                EndContext();
#line 35 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\editConfiguration.cshtml"
                                                                                                                                                              }

#line default
#line hidden
                PopWriter();
            }
            ), 1488, 47, false);
            EndWriteAttribute();
            BeginContext(1536, 380, true);
            WriteLiteral(@">
                </div>
            </div>
            <!--end row-->
            <!--row-->
            <div class=""form-group row"">
                <label class=""col-sm-2 form-control-label text-xs-right"">Dung lượng:</label>
                <div class=""col-sm-5"">
                    <input type=""text"" class=""form-control boxed"" placeholder=""Dung lượng"" name=""storage""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1916, "\"", 1973, 1);
            WriteAttributeValue("", 1924, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#line 43 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\editConfiguration.cshtml"
                                                                                                                  if (Model != null) {

#line default
#line hidden
                BeginContext(1952, 13, false);
#line 43 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\editConfiguration.cshtml"
                                                                                                                                       Write(Model.storage);

#line default
#line hidden
                EndContext();
#line 43 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\editConfiguration.cshtml"
                                                                                                                                                                 }

#line default
#line hidden
                PopWriter();
            }
            ), 1924, 49, false);
            EndWriteAttribute();
            BeginContext(1974, 482, true);
            WriteLiteral(@">
                </div>
            </div>
            <!--end row-->
            <!--row-->
            <div class=""form-group row"">
                <div class=""form-group row"">
                    <div class=""col-sm-10 col-sm-offset-2"">
                        <button type=""submit"" class=""btn btn-primary""> Submit </button>
                    </div>
                </div>
            </div>
            <!--end row-->

        </div>
    </form>
</article>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591