#pragma checksum "C:\Users\frez70\source\repos\MVC Blog\MVC Blog\Views\Blog\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "106c46144d59b189401c5a911c1f614f75682018"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Blog), @"mvc.1.0.view", @"/Views/Blog/Blog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Blog.cshtml", typeof(AspNetCore.Views_Blog_Blog))]
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
#line 1 "C:\Users\frez70\source\repos\MVC Blog\MVC Blog\Views\_ViewImports.cshtml"
using MVC_Blog;

#line default
#line hidden
#line 2 "C:\Users\frez70\source\repos\MVC Blog\MVC Blog\Views\_ViewImports.cshtml"
using MVC_Blog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"106c46144d59b189401c5a911c1f614f75682018", @"/Views/Blog/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b45605896f970b14940b194dedf96b662ede0e4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 15, true);
            WriteLiteral("<h1>Blog</h1>\r\n");
            EndContext();
#line 2 "C:\Users\frez70\source\repos\MVC Blog\MVC Blog\Views\Blog\Blog.cshtml"
  
    foreach (var item in Models.allNews)
    {

#line default
#line hidden
            BeginContext(68, 503, true);
            WriteLiteral(@"        <div class=""col-6 col-sm-6 col-lg-4"">
            <h2>Heading</h2>
            <p>
                Bootstrap is a front-end framework that uses CSS and JavaScript to facilitate responsive Web design. Bootply is a playground for Bootstrap that enables developers and designers to test, prototype and create mockups using Bootstrap
                friendly HTML, CSS and Javascript.
            </p>
            <p><a class=""btn btn-default"" href=""#"">View details »</a></p>
        </div>
");
            EndContext();
#line 13 "C:\Users\frez70\source\repos\MVC Blog\MVC Blog\Views\Blog\Blog.cshtml"
    }

#line default
#line hidden
            BeginContext(581, 4, true);
            WriteLiteral("\r\n\r\n");
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
