#pragma checksum "C:\Users\Gian\Desktop\Proyecto-Final\Views\Cuenta\Registro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42377f0e06ecc822d0c644f12a47746b7b377302"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuenta_Registro), @"mvc.1.0.view", @"/Views/Cuenta/Registro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cuenta/Registro.cshtml", typeof(AspNetCore.Views_Cuenta_Registro))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42377f0e06ecc822d0c644f12a47746b7b377302", @"/Views/Cuenta/Registro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db32e4c60afea8645d8f000c0ecb7d5f01c2ab1", @"/Views/_ViewImports.cshtml")]
    public class Views_Cuenta_Registro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formulario formulario-registro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2069, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07a355a5295247b585c0a7c408914aaa", async() => {
                BeginContext(45, 2017, true);
                WriteLiteral(@"
          <div class=""form-group"">
            <div class=""row div-h3"">
              <div class=""col-12"">
                <h3>Registro</h3>
              </div>
            </div>
            <div class=""row"">
              <div class=""col-12"">
                <label for="""">Nombres *</label>
                <input type=""text"" name="""" id="""" class=""form-control"" placeholder="""" aria-describedby=""helpId"">
              </div>
            </div>
            <div class=""row"">
              <div class=""col-12"">
                <label for="""">Apellidos *</label>
                <input type=""text"" name="""" id="""" class=""form-control"" placeholder="""" aria-describedby=""helpId"">
              </div>
            </div>
            <div class=""row"">
              <div class=""col-12"">
                <label for="""">Correo electrónico *</label>
                <input type=""email"" name="""" id="""" class=""form-control"" placeholder="""" aria-describedby=""helpId"">
              </div>
            </div>
            <div class=""row"">
   ");
                WriteLiteral(@"           <div class=""col-12"">
                <label for="""">Teléfono *</label>
                <input type=""textw"" name="""" id="""" class=""form-control"" placeholder="""" aria-describedby=""helpId"">
              </div>
            </div>
            <div class=""row"">
              <div class=""col-12"">
                <label for="""">Contraseña *</label>
                <input type=""password"" name="""" id="""" class=""form-control"" placeholder="""" aria-describedby=""helpId"">
              </div>
            </div>
            <div class=""row"">
              <div class=""col-12"">
                <input type=""checkbox"" class=""""> He leído y acepto los Términos y Condiciones así como las Políticas de Privacidad de Maribel SAC.
              </div>
            </div>
            <div class=""row div-btn-registrar"">
              <div class=""col-12"">
                <button type=""submit"" class=""btn btn-registrar"">Registrar</button>
              </div>
            </div>
          </div>    
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
