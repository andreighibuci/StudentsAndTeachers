#pragma checksum "G:\Facultate\SE\StudentsAndTeachers\StudentsAndTeachers\StudentsAndTeachers\Views\Classes\Class.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77540c7f64f932471c13d44a72cbf9e08b341b5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Classes_Class), @"mvc.1.0.view", @"/Views/Classes/Class.cshtml")]
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
#line 1 "G:\Facultate\SE\StudentsAndTeachers\StudentsAndTeachers\StudentsAndTeachers\Views\_ViewImports.cshtml"
using StudentsAndTeachers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Facultate\SE\StudentsAndTeachers\StudentsAndTeachers\StudentsAndTeachers\Views\_ViewImports.cshtml"
using StudentsAndTeachers.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Facultate\SE\StudentsAndTeachers\StudentsAndTeachers\StudentsAndTeachers\Views\_ViewImports.cshtml"
using StudentsAndTeachers.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77540c7f64f932471c13d44a72cbf9e08b341b5c", @"/Views/Classes/Class.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5aaae9021f5843ef0db24e1ff0ad9fa04ab405e", @"/Views/_ViewImports.cshtml")]
    public class Views_Classes_Class : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClassCourse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>");
#nullable restore
#line 2 "G:\Facultate\SE\StudentsAndTeachers\StudentsAndTeachers\StudentsAndTeachers\Views\Classes\Class.cshtml"
Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClassCourse> Html { get; private set; }
    }
}
#pragma warning restore 1591
