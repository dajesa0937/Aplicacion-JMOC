#pragma checksum "C:\Users\dsala\source\repos\AppSenaJmoc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f912763ce05ce1f9eae37e738708f978e09ed37f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\dsala\source\repos\AppSenaJmoc\Views\_ViewImports.cshtml"
using AppSenaJmoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dsala\source\repos\AppSenaJmoc\Views\_ViewImports.cshtml"
using AppSenaJmoc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f912763ce05ce1f9eae37e738708f978e09ed37f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f320338eaec87a17dc582e9816bcd676e02bfa2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"es\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f912763ce05ce1f9eae37e738708f978e09ed37f3206", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>JMOC</title>
    <link rel=""stylesheet"" href=""../css/styleindex.css"">
    <link href='https://unpkg.com/boxicons@2.0.7/css/boxicons.min.css' rel='stylesheet'>
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Open+Sans:wght@300;400;700&display=swap"" rel=""stylesheet"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f912763ce05ce1f9eae37e738708f978e09ed37f4791", async() => {
                WriteLiteral(@"
    <header class=""header"" id=""inicio"">

        <nav class=""menu-navegacion"">
            <a href=""#inicio"">Inicio</a>
            <a href=""#servicios"">Servicios</a>
            <a href=""#portafolio"">Portafolio</a>
            <a href=""#expertos"">Expertos</a>
            <a href=""#contactos"">Contactos</a>
            <a href=""#"">APP JMO</a>



        </nav>
        <div class=""contenedor head"">
            <h1 class=""titulo"">
                Especialistas en Maquinas Agroindustriales
            </h1>
            <p class=""copy"">Tu Confianza es Nuestra Prioridad</p>
        </div>
    </header>

    <main>
        <section class=""contenedor"" id=""servicios"">
            <h2 class=""subtitulo"">Nuestro Servicio </h2>
            <div class=""contenedor-servicios"">
                <img src=""../img/jmologooficial.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 1503, "\"", 1509, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                <div class=""isometrica-servicios"">
                    <div class=""service"">

                        <h3 class=""n-service""><span class=""number"">1</span>Confianza </h3>
                        <p>
                            Somos una empresa dedicada al servicio y a la satisfaccion de nuestros
                            CLIENTES lo cual nos permite generar CONFIANZA Empresarial en el mercado de
                            Equipos y Maquinaria Agroindustrial.
                        </p>

                    </div>
                    <div class=""service"">

                        <h3 class=""n-service""><span class=""number"">2</span>Seriedad</h3>
                        <p>
                            Nuestra Experiencia en el mercado de maquinaria y servicios nos permite atender
                            a nuestros Clientes con la Seriedad de nuestros trabajos y ofrecerles el mejor servicio con calidad.
                        </p>

                    </div>
       ");
                WriteLiteral(@"             <div class=""service"">

                        <h3 class=""n-service""><span class=""number"">3</span>Puntualidad</h3>
                        <p>
                            Nuestros trabajos entregados en la fecha programada nos permite ser la empresa
                            reconocida en el mercado nacional por la Puntualidad que nos caracteriza.
                        </p>

                    </div>


                </div>
            </div>
        </section>
        <section class=""gallery"" id=""portafolio"">
            <div class=""contenedor"">
                <h2 class=""subtitulo"">Proyectos Ejecutados</h2>
                <div class=""contenedor-galeria"">
                    <img src=""../img/jmoc02.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 3285, "\"", 3291, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-galeria\">\r\n                    <img src=\"../img/imagenheader002.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 3372, "\"", 3378, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-galeria\">\r\n                    <img src=\"../img/imagenpresentacionheader.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 3468, "\"", 3474, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-galeria\">\r\n                    <img src=\"../img/jmoc03.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 3546, "\"", 3552, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-galeria\">\r\n                    <img src=\"../img/imagenproyecto01.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 3634, "\"", 3640, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-galeria\">\r\n                    <img src=\"../img/imagenproyecto02.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 3722, "\"", 3728, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-galeria\">\r\n                </div>\r\n            </div>\r\n        </section>\r\n        <section class=\"imagen-ligth\">\r\n            <img src=\"../icons/close.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 3897, "\"", 3903, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"close\">\r\n            <img src=\"../img/log02.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 3960, "\"", 3966, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""agregar-imagen"">
        </section>

        <section class=""contenedor"" id=""expertos"">
            <h2 class=""subtitulo""> Expertos en:</h2>

            <section class=""experts"">
                <div class=""cont-expert"">
                    <img src=""../img/unocopia.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 4255, "\"", 4261, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <h3 class=\"n-expert\">Asesoria</h3>\r\n                </div>\r\n                <div class=\"cont-expert\">\r\n                    <img src=\"../img/instalacion - copia.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 4449, "\"", 4455, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <h3 class=\"n-expert\">Instalacion</h3>\r\n                </div>\r\n                <div class=\"cont-expert\">\r\n                    <img src=\"../img/electric-4198293_640.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 4647, "\"", 4653, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <h3 class=""n-expert"">Reparacion</h3>
                </div>
            </section>

        </section>


    </main>

    <footer id=""contactos"">
        <div class=""contenedor footer-content"">
            <div class=""contact-us"">
                <h2 class=""brand"">JMO</h2>
                <P>Servicio Tecnico Especializado.</P>
                <P>--------------------------------------------</P>
                <P>Telefono: 304 466 3430.</P>
                <P>Email: juliomoviedo@gmail.com.</P>
                <P>Direccion: Cartagena-Bolivar(Colombia)</P>
                <P>www.jmo.com.co</P>
            </div>
            <div class=""social-media"">
                <a href=""./"" class=""social-media-icon"">
                    <i class='bx bxl-facebook'></i>
                </a>
                <a href=""./"" class=""social-media-icon"">
                    <i class='bx bxl-twitter'></i>
                </a>
                <a href=""./"" class=""social-media-icon"">
    ");
                WriteLiteral(@"                <i class='bx bxl-instagram'></i>
                </a>
            </div>
        </div>

        <div class=""line""></div>
    </footer>


    <script src=""/dev/js/menu.js""></script>
    <script src=""/dev/js/ligthtbox.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
