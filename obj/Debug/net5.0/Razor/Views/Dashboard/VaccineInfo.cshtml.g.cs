#pragma checksum "C:\Users\Jawad\Desktop\CovidCare-main\CovidCare\Views\Dashboard\VaccineInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f263c61cb0912be65ba772381831d3fa26884174"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_VaccineInfo), @"mvc.1.0.view", @"/Views/Dashboard/VaccineInfo.cshtml")]
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
#line 1 "C:\Users\Jawad\Desktop\CovidCare-main\CovidCare\Views\_ViewImports.cshtml"
using CovidCare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jawad\Desktop\CovidCare-main\CovidCare\Views\_ViewImports.cshtml"
using CovidCare.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f263c61cb0912be65ba772381831d3fa26884174", @"/Views/Dashboard/VaccineInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a59a76858463a9bd387976fea129e4d681b9291a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Dashboard_VaccineInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""backgroundWhiteBorder"">
    <div class="" container p-3"">
        <div class="" row pt-4"">
            <div class=""card text-left"" style=""width: 100%"" height:30%>
                <div class=""card-header bg-dark text-light ml-0 row container"">
                    <div class=""col-6"">
                        <i class=""fas fa-info-circle""></i> VACCINE INFORMATION
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""container p-3"">
    <div>
        <ul>
            <h3>Steps:</h3>
            <li>If you are not registerd yet for the vaccine, you can click the link and that will direct you to the website where you can register for the vaccine.</li>
            <li>The link is here. <a href=""https://surokkha.gov.bd/"" target=""_blank""> Surokha Website</a> </li>
            <li>After registration, you will be notified reagrding date and place via sms. </li>
            <li>
                You have to collect the vaccine card from the given link to");
            WriteLiteral(@" get the vaccine from the respective centre.
                <a href=""https://surokkha.gov.bd/vaccine-card"" target=""_blank"">Collect Vaccine Card</a>
            </li>
            <li>
                When you complete both the vaccine dose, then you are vaccinated and you can collect the certifaicate from the given link.
                <a href=""https://surokkha.gov.bd/certificate"" target=""_blank"">Collect Vaccine Certificate</a>
            </li>
            <li>
                One can verify his certificate from the given link.
                <a href=""https://surokkha.gov.bd/verify"" target=""_blank"">Verify Vaccine Certificate</a>
            </li>
        </ul>
    </div>
</div>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
