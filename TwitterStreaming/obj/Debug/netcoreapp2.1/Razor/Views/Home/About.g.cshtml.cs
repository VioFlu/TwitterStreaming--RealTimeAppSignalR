#pragma checksum "C:\TwitterStream\TwitterStreaming- RealTimeAppSignalR\TwitterStreaming\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bc7469895186f6b4ac5ab1d5fb1e823e3a68294"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\TwitterStream\TwitterStreaming- RealTimeAppSignalR\TwitterStreaming\Views\_ViewImports.cshtml"
using TwitterStreaming;

#line default
#line hidden
#line 2 "C:\TwitterStream\TwitterStreaming- RealTimeAppSignalR\TwitterStreaming\Views\_ViewImports.cshtml"
using TwitterStreaming.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bc7469895186f6b4ac5ab1d5fb1e823e3a68294", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0371287e10548303a1de7b0ed29639a31b987505", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\TwitterStream\TwitterStreaming- RealTimeAppSignalR\TwitterStreaming\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About application";

#line default
#line hidden
            BeginContext(53, 1528, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-6"">
        <h2>Application uses</h2>
        <ul>
            <li>Sample pages using: <a href=""https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-2.2""> ASP.NET Core MVC</a></li>
            <li>Client side using:<a href=""https://www.javascript.com/"">JavaScript, jQuery, CSS</a></li>
            <li>Theming using: <a href=""https://getbootstrap.com/"">Bootstrap</a></li>
            <li>Real-time implementation using <a href=""https://dotnet.microsoft.com/apps/aspnet/real-time"">SignalR library</a></li>
        </ul>
    </div>
    <div class=""col-md-6"">
        <h2>Twitter APIs</h2>
        <ul>
            <li>
                <a href=""https://developer.twitter.com/en/docs/basics/authentication/overview/using-oauth"">Authentication using Ouath</a>
                OAuth is used by twitter providing mechanisms for authentication.
                It enables developers to get access to API(s).
            </li>
            <li>
        ");
            WriteLiteral(@"        <a href=""https://developer.twitter.com/en/docs/tweets/search/api-reference/get-search-tweets"">Standard search API</a>
                Returns a collection of relevant Tweets matching a specified query.
                Please note that Twitter's search service and, by extension, the Search API is not meant to be an exhaustive source of Tweets.
                Not all Tweets will be indexed or made available via the search interface.
            </li>
        </ul>
    </div>

</div>
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
