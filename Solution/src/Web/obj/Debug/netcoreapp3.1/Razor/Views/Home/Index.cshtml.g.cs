#pragma checksum "/Users/kevinchristopherpiovezan/Documents/Univesp/Projeto_Integrador_1/Univesp_PI1/Solution/src/Web/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "473e215655af1a3e4c7d28c63e263b45f2438518"
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
#line 1 "/Users/kevinchristopherpiovezan/Documents/Univesp/Projeto_Integrador_1/Univesp_PI1/Solution/src/Web/Views/_ViewImports.cshtml"
using Univesp.CaminhoDoMar.ProjetoIntegradorWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kevinchristopherpiovezan/Documents/Univesp/Projeto_Integrador_1/Univesp_PI1/Solution/src/Web/Views/_ViewImports.cshtml"
using Univesp.CaminhoDoMar.ProjetoIntegradorWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"473e215655af1a3e4c7d28c63e263b45f2438518", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ffe5b36c4dd5d15afec9e25e5dfb444bb805f1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Univesp.CaminhoDoMar.ProjetoIntegrador.Web.Models.HomeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dashboard.css?v=14032024.1604"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/chartjs/dist/chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/chartjs/dist/custom_plugins.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/chartjs/dist/chartjs-plugin-datalabels.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/palette.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/kevinchristopherpiovezan/Documents/Univesp/Projeto_Integrador_1/Univesp_PI1/Solution/src/Web/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home";


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "473e215655af1a3e4c7d28c63e263b45f24385185688", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<div class=""content-title"">
    <h4 class=""page-title"">Bem vindo(a)</h4>
    <a id=""buscarAlunos"" href=""/busca"" class=""btn btn-red"" style=""position:absolute; right: 0; top:10px; display:none;"">Buscar alunos <i class=""fas fa-search ml-2""></i></a>
</div>

<div class=""dash"">
    <div class=""cards-wrapper"">
        <section class=""card-dashboard"" id=""total-alunos"">
            <i class=""fas fa-user card-icon""></i>
            <div class=""card-data"">
                <h5> ");
#nullable restore
#line 19 "/Users/kevinchristopherpiovezan/Documents/Univesp/Projeto_Integrador_1/Univesp_PI1/Solution/src/Web/Views/Home/Index.cshtml"
                Write(Model.Alunos.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h5>
                <p class=""p-1"">Total de Alunos </p>
            </div>
        </section>
        <section class=""card-dashboard"" id=""total-alunos-escola-publica"">
            <i class=""fas fa-user card-icon""></i>
            <div class=""card-data"">
                <h5> ");
#nullable restore
#line 26 "/Users/kevinchristopherpiovezan/Documents/Univesp/Projeto_Integrador_1/Univesp_PI1/Solution/src/Web/Views/Home/Index.cshtml"
                Write(Model.Alunos.Count(c => c.EnsinoMedio_Escola_Publica));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h5>
                <p class=""p-1"">Alunos ensino médio em escola pública</p>
            </div>
        </section>
        <section class=""card-dashboard"" id=""total-alunos-faculdade"">
            <i class=""fas fa-user card-icon""></i>
            <div class=""card-data"">
                <h5> ");
#nullable restore
#line 33 "/Users/kevinchristopherpiovezan/Documents/Univesp/Projeto_Integrador_1/Univesp_PI1/Solution/src/Web/Views/Home/Index.cshtml"
                Write(Model.Alunos.Count(c => c.Cursou_Faculdade));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h5>
                <p class=""p-1"">Alunos que cursaram faculdade previamente</p>
            </div>
        </section>
        <section class=""card-dashboard"" id=""total-alunos-professores"">
            <i class=""fas fa-user card-icon""></i>
            <div class=""card-data"">
                <h5> ");
#nullable restore
#line 40 "/Users/kevinchristopherpiovezan/Documents/Univesp/Projeto_Integrador_1/Univesp_PI1/Solution/src/Web/Views/Home/Index.cshtml"
                Write(Model.Alunos.Count(c => c.Professor));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h5>
                <p class=""p-1"">Alunos que também são professores</p>
            </div>
        </section>
        <section class=""card-dashboard"" id=""total-alunos-servidores-publicos"">
            <i class=""fas fa-user card-icon""></i>
            <div class=""card-data"">
                <h5> ");
#nullable restore
#line 47 "/Users/kevinchristopherpiovezan/Documents/Univesp/Projeto_Integrador_1/Univesp_PI1/Solution/src/Web/Views/Home/Index.cshtml"
                Write(Model.Alunos.Count(c => c.Servidor_Publico));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h5>
                <p class=""p-1"">Alunos que também são servidores públicos</p>
            </div>
        </section>
        <section class=""card-dashboard"" id=""total-alunos-sptrans"">
            <i class=""fas fa-user card-icon""></i>
            <div class=""card-data"">
                <h5> ");
#nullable restore
#line 54 "/Users/kevinchristopherpiovezan/Documents/Univesp/Projeto_Integrador_1/Univesp_PI1/Solution/src/Web/Views/Home/Index.cshtml"
                Write(Model.Alunos.Count(c => c.Cadastro_SpTrans));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\n                <p class=\"p-1\">Alunos que pediram bilhete de estudante</p>\n            </div>\n        </section>\n    </div>\n\n\n");
            WriteLiteral("\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "473e215655af1a3e4c7d28c63e263b45f243851810753", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "473e215655af1a3e4c7d28c63e263b45f243851811777", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "473e215655af1a3e4c7d28c63e263b45f243851812801", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "473e215655af1a3e4c7d28c63e263b45f243851813825", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<style>\n    ");
            WriteLiteral(@"@media screen and (min-width: 768px) {
        #buscarAlunos {
            display: block !important;
        }
    }

    .dash {
        display: flex;
    }

    .side-data {
        font-size: 1rem;
    }

    .cards-wrapper {
        display: flex;
        flex-wrap: wrap;
        /*flex: 0 0 300px;*/
    }

    #graphs-section{
        flex-grow:1;
    }

    .card-dashboard {
        margin: 0;
        margin-bottom: 1rem;
        flex: 0 0 calc(100%);
        border-radius: .5rem;
    }
</style>

<script>
    loadFormFromQueryString();
    charts = {}
    meses = [""JAN"", ""FEV"", ""MAR"", ""ABR"", ""MAI"", ""JUN"", ""JUL"", ""AGO"", ""SET"", ""OUT"", ""NOV"", ""DEZ""];
    const lineColors = ['rgb(240, 125, 0)', 'rgb(0, 158, 190)', 'rgb(112,132,10)', 'rgb(89, 89, 89)'];
    let idxColors = 0;

    with (document.getElementsByTagName('main')[0]) {
        classList.remove(""container"")
        classList.add(""container-fluid"");
    }

    const showGraphHideGraph = (show, hide) => {
        titleHide = document.getElementById");
            WriteLiteral(@"(`${hide}_title`).classList.remove('graph-selected');
        containerHide = document.getElementById(`${hide}_container`).style.display = 'none';

        titleShow = document.getElementById(`${show}_title`).classList.add('graph-selected');
        containerShow = $(`#${show}_container`).show();
    }

    function criaGraficoDonut(id_canvas, graphData, insideText) {
        const data = {
            labels: graphData.labels,
            datasets: [{
                label: '',
                data: graphData.values,
                backgroundColor: [
                    'rgba(255,0,0,0.5)',
                    'rgba(249,176,0,0.6)',
                    'rgba(189, 196, 22, 0.6)',
                    'rgba(0, 158, 150,0.6)',
                    'rgba(112,132,10,0.6)',
                    'rgba(122,122,122,0.6)',
                ],
                hoverOffset: 4,
                cutout: ""45%""
            }],
        };

        let total = data.datasets[0].data.reduce((prev, curr) => prev + curr, 0);

        ");
            WriteLiteral(@"const config = {
            type: 'pie',
            data: data,
            plugins: [ChartDataLabels, {
                id: 'text',
                beforeDraw: function (chart, a, b) {
                    var width = chart.width,
                        height = chart.height,
                        ctx = chart.ctx;

                    ctx.restore();
                    var fontSize = ""18px"";
                    ctx.font = fontSize + "" sans-serif"";
                    ctx.textBaseline = ""middle"";

                    var text = insideText.toString().replace('.', ',') + ""%""
                    textX = Math.round((width - ctx.measureText(text).width) / 2),
                        textY = (height / 2) + 29;

                    ctx.fillText(text, textX, textY);
                    ctx.save();
                }
            }],
            options: {
                responsive: true,
                maintainAspectRatio: false,
                plugins: {
                    datalabels: {
                       ");
            WriteLiteral(@" labels: {
                            name: {
                                align: 'top',
                                font: { size: 0 },
                                color: ""#000"",
                                formatter: function (value, ctx) {
                                    percentage = value / total;
                                    if (percentage < 0.05)
                                        return """";
                                    return ctx.chart.data.labels[ctx.dataIndex].slice(0, 20);
                                }
                            }
                        }
                    },
                    legend: {
                        display: true
                    },
                    tooltip: {
                        callbacks: {
                            label: (tooltipItem, data) => {
                                label = tooltipItem.label;
                                value = tooltipItem.parsed;
                                if (label.lengt");
            WriteLiteral(@"h > 30)
                                    return [label.slice(0, 30), label.slice(30) + ` : ${value.milharBRL()}`]
                                else
                                    return label + ` : ${value.milharBRL()}`;
                            }
                        }
                    }
                },
            }
        };

        var elemGraph = document.getElementById(id_canvas);
        charts[id_canvas] = new Chart(elemGraph, config);
    }

    function criaGraficoLinha(id_canvas, graphData) {
        const data = {
            labels: meses,
            datasets: []
        };

        for (x of graphData) {

            data.datasets.push({
                label: x.ciclo,
                data: x.progresso.map(p => p.renovados_Porcentagem),
                borderColor: lineColors[idxColors],
                tension: 0.1
            });

            idxColors = (idxColors + 1) % lineColors.length;
        }


        const config = {
            type: 'line',
            dat");
            WriteLiteral(@"a: data,
            options: {
                responsive: true,
                maintainAspectRatio: false,
                beginAtZero: true,
                scales: {
                    x: {

                        grid: {
                            display: false,
                        },
                    },
                    y: {
                        suggestedMin: 0,
                        grid: {
                            color: ""#00000008"",
                        },
                        ticks: {
                            callback: function (value) {
                                return value.toFixed(0) + '%';
                            },
                        },
                        scaleLabel: {
                            display: true,
                            labelString: 'Percentage',
                        }
                    }
                },
                plugins: {
                    legend: {
                        display: true
                   ");
            WriteLiteral(@" },
                    tooltip: {
                        callbacks: {
                            label: (tooltipItem, data) => {
                                label = tooltipItem.dataset.label;
                                value = tooltipItem.parsed;

                                return label + "": "" + value.y.toFixed(2) + ""%""
                            },
                        }
                    },
                }
            },
        };

        var elemGraph = document.getElementById(id_canvas);
        charts[id_canvas] = new Chart(elemGraph, config);
    }

    function criaGraficoBarraVertical(id_canvas, graphData) {

        //convertendo pra porcentagem
        for (let i = 0; i < graphData.labels.length; i++) {
            vl = graphData.values[i];
            pend = graphData.pendentes[i];
            tot = vl + pend;
            graphData.values[i] = (vl / tot)*100;
            graphData.pendentes[i ] = (pend / tot)*100;
        }

        const data = {
            labels: grap");
            WriteLiteral(@"hData.labels,
            datasets: [{
                label: 'Finalizados',
                data: graphData.values,
                borderColor: ""rgb(112,132,10)"",
                backgroundColor: ""rgba(112,132,10, .7)"",
                borderWidth: 2
            },
            {
                label: 'Pendentes',
                data: graphData.pendentes,
                borderColor: ""#F99000"",
                backgroundColor: ""#F9B000"",
                borderWidth: 2
            }]
        };

        const config = {
            type: 'bar',
            data: data,
            options: {
                responsive: true,                
                maintainAspectRatio: false,
                scales: {
                    x: {
                        stacked: true,
                        grid: {
                            display: false,
                        },
                    },
                    y: {
                        stacked: true,
                        min: 0,
                  ");
            WriteLiteral(@"      max: 100,
                        type: 'linear',
                        grace: ""0%"",
                        grid: {
                            color: ""#00000008"",
                        },
                        ticks: {
                            precision: 0,
                            callback: function (value) {
                                return value.toFixed(0) + '%';
                            },
                        },
                        scaleLabel: {
                            display: true,
                            labelString: 'Percentage',
                        }
                    }
                },
                plugins: {
                    legend: {
                        display: true
                    },
                    tooltip: {
                        callbacks: {
                            label: (tooltipItem, data) => {
                                label = tooltipItem.dataset.label;
                                value = tooltipItem.par");
            WriteLiteral(@"sed;

                                return label + "": "" + value.y.toFixed(2) + ""%""
                            },
                        }
                    },
                }
            },
        };

        var elemGraph = document.getElementById(id_canvas);
        charts[id_canvas] = new Chart(elemGraph, config);
    }
    
    function criaGraficoBarraVerticalRenovacaoCadastral(id_canvas, graphData) {
        percentages = [];
        for (let i = 0; i < graphData.renovados.length; i++) {
            percentages.push((graphData.renovados[i] / graphData.values[i]) * 100);
        }

        const data = {
            labels: graphData.labels,
            datasets: [{
                label: 'Alunos a Renovar',
                data: graphData.values,
                borderColor: ""#F99000"",
                backgroundColor: ""#F9B000"",
                borderWidth: 2
            },{
                label: 'Alunos Renovados',
                data: graphData.renovados,
                borderColor: ""rgb(1");
            WriteLiteral(@"12,132,10)"",
                backgroundColor: ""rgba(112,132,10, .7)"",
                borderWidth: 2
            },{
                label: '% Renovados',
                data: percentages,
                borderColor: ""rgb(255,0,0)"",
                backgroundColor: ""rgba(255,0,0, .7)"",
                borderWidth: 2
            }]
        };
        const config = {
            type: 'bar',
            data: data,
            options: {
                responsive: true,                
                maintainAspectRatio: false,
                scales: {
                    x: {
                        grid: {
                            display: false,
                        },
                    },
                    y: {
                        grid: {
                            color: ""#00000008"",
                        },
                    }
                },
                plugins: {
                    tooltip: {
                        callbacks: {
                            label: (toolti");
            WriteLiteral(@"pItem, data) => {
                                label = tooltipItem.dataset.label;
                                value = tooltipItem.parsed;
                                if (label.length > 30)
                                    return [label.slice(0, 30), label.slice(30) + ` : ${value.y.milharBRL()}`]
                                else
                                    return tooltipItem.dataset.label + ` : ${value.y.milharBRL()}`;
                                
                            },
                        }
                    },
                    legend: {
                        display: true
                    },
                }
            },
        };

        var elemGraph = document.getElementById(id_canvas);
        charts[id_canvas] = new Chart(elemGraph, config);
    }

    const obtemDadosDashboard = () => {

        $.ajax({type: ""POST"",
            url: `/dados`,
            contentType: ""application/json"",
            data: JSON.stringify(""ok""),
        }).done(fun");
            WriteLiteral(@"ction (data) {
            for (key in charts) {
                        if (charts[key] != null) charts[key].destroy();
            }
                    
            criaGraficoBarraVertical(""progresso_filial"",
            {
                labels: data.progressoUnidade.labels,
                values: data.progressoUnidade.values,
                pendentes: data.progressoUnidade.pendentes,
            });
            
            var percentage = Math.round(
                ((data.progressoCicloEnviadoIncompleto + data.progressoCicloEnviadoCompleto) /
                    (data.progressoCicloPendentes + data.progressoCicloNaoRenovar +
                    data.progressoCicloRecebidoIncompleto + 
                    data.progressoCicloRecebidoCompleto + 
                    data.progressoCicloEnviadoIncompleto + 
                        data.progressoCicloEnviadoCompleto)) * 10000)/100;


            if (isNaN(percentage)){
                percentage = 0;
            }
            criaGraficoDonut(""progresso_c");
            WriteLiteral(@"iclo"",
            {
                labels: [""Pendentes"", ""Recebido incompleto"", ""Recebido completo"", ""Enviado incompleto"", ""Enviado completo"", ""Não renovar""],
                values: [data.progressoCicloPendentes, data.progressoCicloRecebidoIncompleto, data.progressoCicloRecebidoCompleto, data.progressoCicloEnviadoIncompleto, data.progressoCicloEnviadoCompleto, data.progressoCicloNaoRenovar],
            }, percentage);

            criaGraficoBarraVerticalRenovacaoCadastral(""renovacao_cadastral"",
            {
                labels: data.progressoCiclo.labels,
                values: data.progressoCiclo.values,
                renovados: data.progressoCiclo.renovados,
                });

            criaGraficoLinha('comparativo_envio', data.renovados);

        }).fail(function (xhr, status, error) {
            if (xhr.status == 400) {
                if (xhr.responseText !== """") {
                    toastr.error(xhr.responseText);
                    return;
                }
            }
          ");
            WriteLiteral("  toastr.error(\"Não foi possível gerar os dados do dashboard.\");\n            console.log(xhr.responseText);\n        });\n\n    }\n\n    // obtemDadosDashboard();\n\n    $(function () {\n        $(\'[data-toggle=\"tooltip\"]\').tooltip()\n    })\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Univesp.CaminhoDoMar.ProjetoIntegrador.Web.Models.HomeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
