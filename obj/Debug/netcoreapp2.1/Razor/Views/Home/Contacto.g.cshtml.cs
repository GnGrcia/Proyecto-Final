#pragma checksum "C:\Users\Gian\Desktop\Proyecto-Final\Views\Home\Contacto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e107e8dccd50e518ee5e1061319ffad3fe553f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contacto), @"mvc.1.0.view", @"/Views/Home/Contacto.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contacto.cshtml", typeof(AspNetCore.Views_Home_Contacto))]
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
#line 1 "C:\Users\Gian\Desktop\Proyecto-Final\Views\_ViewImports.cshtml"
using Proyecto_Final;

#line default
#line hidden
#line 2 "C:\Users\Gian\Desktop\Proyecto-Final\Views\_ViewImports.cshtml"
using Proyecto_Final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e107e8dccd50e518ee5e1061319ffad3fe553f6", @"/Views/Home/Contacto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db32e4c60afea8645d8f000c0ecb7d5f01c2ab1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contacto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Gian\Desktop\Proyecto-Final\Views\Home\Contacto.cshtml"
  
    ViewData["Title"] = "Contacto";

#line default
#line hidden
            BeginContext(44, 1860, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""formulario-contacto col-md-6"">
        <h1 class=""display-5 mt-5 text-center"">Formulario de Contacto</h1>
        <div class=""form-group"">
            <div class=""row"">
                <div class=""h3 font-weight-normal col-md-4"">
                    Nombre:
                </div>
                <div class=""col-md-7"">
                    <input type=""text"" class=""form-control"">
                </div>
            </div>
            <div class=""row mt-4"">
                <div class=""h3 font-weight-normal col-md-4"">
                    E-mail:
                </div>
                <div class=""col-md-7"">
                    <input type=""text"" class=""form-control"">
                </div>
            </div>
            <div class=""row mt-4"">
                <div class=""h3 font-weight-normal col-md-4"">
                    Asunto:
                </div>
                <div class=""col-md-7"">
                    <input type=""text"" class=""form-control"">
   ");
            WriteLiteral(@"             </div>
            </div>
            
        </div>
    </div>

    <div class=""formulario-contacto-mensaje col-md-6"">
        
        <div class=""form-group"">
            <div class=""h5 mt-4 align-bottom"">Mensaje:</div>
            <div class=""row"">
                <div class=""col-md-12"">
                    <textarea class=""form-control col-md-10 mt-3"" rows=""8"" cols=""50""></textarea>
                </div>
            </div>
        </div>
    </div>
    
</div>
<div class=""row"">
    <div class=""col-md-6"">
        <div class=""form-group"">
            <div class=""row"">
                <button type=""submit"" class=""btn btn-contacto-enviar pt-3 pb-3 pl-5 pr-5 ml-auto mr-auto"">Enviar</button>
            </div>    
        </div>
    </div>
    <div class=""col-md-6"">
    </div>
</div>");
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
