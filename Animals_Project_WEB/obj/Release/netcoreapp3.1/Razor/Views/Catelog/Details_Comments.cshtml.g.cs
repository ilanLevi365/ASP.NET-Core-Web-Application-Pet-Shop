#pragma checksum "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33bddbef387be8afe730d89d9160c053a76332e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catelog_Details_Comments), @"mvc.1.0.view", @"/Views/Catelog/Details_Comments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33bddbef387be8afe730d89d9160c053a76332e1", @"/Views/Catelog/Details_Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6dcbe03bb4f4c57f6930087aa8751923fdbdcdc", @"/_ViewImports.cshtml")]
    public class Views_Catelog_Details_Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Animals_Project_WEB.Models.New_Comment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("260"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("260"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Pages"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
  
    ViewBag.Title = "Details_Comments";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 7 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
 foreach (var item in my_Repository.Get_Animals())
{
    if (item.AnimalId == ViewBag.animal_Id)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div align=\"center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33bddbef387be8afe730d89d9160c053a76332e14915", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 264, "~/Images/", 264, 9, true);
#nullable restore
#line 12 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
AddHtmlAttributeValue("", 273, item.Picture_Name, 273, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <h1 id=\"Name_Page\">Catelog</h1>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33bddbef387be8afe730d89d9160c053a76332e16685", async() => {
                WriteLiteral("<h3>Back</h3>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <br />\r\n");
            WriteLiteral(@"        <div class=""container"">
            <br />
            <div class=""row"">
                <div class=""col"">
                    <h4></h4>
                </div>
                <div class=""col"">
                    <h4></h4>
                </div>
                <div align=""left"" class=""col-4"">
                    <div>
");
#nullable restore
#line 32 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
                         using (Html.BeginForm("Add_Comment", "Catelog"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"submit\" value=\"Submit Comment\" class=\"btn badge-primary\" />\r\n");
#nullable restore
#line 35 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
                       Write(Html.EditorFor(model => model.NewComment));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
                       Write(Html.ValidationMessageFor(model => model.NewComment, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
                                                                                                                     
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <br />
                        <br />
                    </div>
                </div>

            </div>
            <div class=""row"">
                <div id=""Details_Titles"" align=""right"" class=""col-3"">
                    <h3>Name >>></h3>
                </div>
                <div align=""left"" class=""col-5"">
                    <h4 id=""Details"">");
#nullable restore
#line 49 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n                <div class=\"col-4\">\r\n                    <h3>Comments on the animal:</h3>\r\n                    <br />\r\n");
#nullable restore
#line 54 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
                      int num = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
                     foreach (var comment in item.Comments)
                    {
                        num++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\r\n                            <div id=\"Details\" align=\"left\" class=\"col\">\r\n                                <h4>");
#nullable restore
#line 60 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
                               Write(num);

#line default
#line hidden
#nullable disable
            WriteLiteral(".  ");
#nullable restore
#line 60 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
                                      Write(comment.Coment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 63 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
            <br />
            <br />
            <div class=""row"">
                <div id=""Details_Titles"" align=""right"" class=""col-3"">
                    <h3>Age >>></h3>
                </div>
                <div align=""left"" class=""col-5"">
                    <h4 id=""Details"">");
#nullable restore
#line 73 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
                                Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                </div>
                <div align=""left"" class=""col-4"">
                    <h4></h4>
                </div>
            </div>
            <br />
            <br />
            <div class=""row"">
                <div id=""Details_Titles"" align=""right"" class=""col-3"">
                    <h3>Description >>></h3>
                </div>
                <div align=""left"" class=""col-5"">
                    <h4 id=""Details"">");
#nullable restore
#line 86 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
                                Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                </div>
                <div align=""left"" class=""col-4"">
                    <h4></h4>
                </div>
            </div>
            <br />
            <br />
            <div class=""row"">
                <div id=""Details_Titles"" align=""right"" class=""col-3"">
                    <h4>Category Name >>></h4>
                </div>
                <div align=""left"" class=""col-5"">
                    <h4 id=""Details"">");
#nullable restore
#line 99 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
                                Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n                <div align=\"left\" class=\"col-4\">\r\n                    <h4></h4>\r\n                </div>\r\n            </div>\r\n            <br />\r\n            <br />\r\n            <br />\r\n        </div>\r\n");
#nullable restore
#line 109 "C:\Users\il365\Documents\תיכנות\פרוייקטים\חנות חיות\Animals_Project_WEB\Views\Catelog\Details_Comments.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Animals_Project_WEB.Repositories.IRepository my_Repository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Animals_Project_WEB.Models.New_Comment> Html { get; private set; }
    }
}
#pragma warning restore 1591