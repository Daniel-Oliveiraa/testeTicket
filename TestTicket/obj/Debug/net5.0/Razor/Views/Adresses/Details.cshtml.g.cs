#pragma checksum "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1994405388f17fb523682d88c868fd80f18e8ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adresses_Details), @"mvc.1.0.view", @"/Views/Adresses/Details.cshtml")]
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
#line 1 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\_ViewImports.cshtml"
using TestTicket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\_ViewImports.cshtml"
using TestTicket.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1994405388f17fb523682d88c868fd80f18e8ca", @"/Views/Adresses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61d9c31e6bc015043d4d4af0d49bd76c095db0df", @"/Views/_ViewImports.cshtml")]
    public class Views_Adresses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestTicket.Models.Adresses>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhes do endere??o</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PostCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayFor(model => model.PostCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Neighborhood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayFor(model => model.Neighborhood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayFor(model => model.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 55 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Complement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayFor(model => model.Complement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 61 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 64 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 67 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 70 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.userId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1994405388f17fb523682d88c868fd80f18e8ca11227", async() => {
                WriteLiteral("Editar endere??o");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
                           WriteLiteral(Model.AdressId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 2364, "\"", 2429, 2);
            WriteAttributeValue("", 2371, "https://localhost:44395/api/Adresses/Index/", 2371, 43, true);
#nullable restore
#line 76 "C:\Users\dodv\OneDrive - GFT Technologies SE\Desktop\Ticket\New folder\testeTicket\TestTicket\Views\Adresses\Details.cshtml"
WriteAttributeValue("", 2414, ViewBag.userId, 2414, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Voltar a listagem</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestTicket.Models.Adresses> Html { get; private set; }
    }
}
#pragma warning restore 1591
