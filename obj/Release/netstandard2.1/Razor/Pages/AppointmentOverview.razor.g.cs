#pragma checksum "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5139801025d7c8b862b1f297222af0c9cfb30efa"
// <auto-generated/>
#pragma warning disable 1591
namespace PowerScheduler.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using PowerScheduler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using PowerScheduler.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
using PowerScheduler.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 160 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
using PowerScheduler.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 161 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
using AthleteScheduler.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 162 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/appointmentoverview")]
    public partial class AppointmentOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    :root {\r\n        --primary-light: #8abdff;\r\n        --primary: #6d5dfc;\r\n        --primary-dark: #5b0eeb;\r\n        --white: #FFFFFF;\r\n        --greyLight-1: #E4EBF5;\r\n        --greyLight-2: #c8d0e7;\r\n        --greyLight-3: #bec8e4;\r\n        --greyDark: #9baacf;\r\n    }\r\n\r\n    body {\r\n        background: var(--greyLight-1);\r\n    }\r\n\r\n    .rz-scheduler {\r\n        height: 100%;\r\n        border-radius: 3rem;\r\n        box-shadow: 0.8rem 0.8rem 1.4rem var(--greyLight-2), -0.2rem -0.2rem 1.8rem var(--white);\r\n        padding: 4rem;\r\n        display: flex;\r\n        background: var(--greyLight-1);\r\n    }\r\n\r\n    .rz-card {\r\n        height: 100%;\r\n        border-radius: 3rem;\r\n        box-shadow: 0.8rem 0.8rem 1.4rem var(--greyLight-2), -0.2rem -0.2rem 1.8rem var(--white);\r\n        background: var(--greyLight-1);\r\n        padding: 4rem;\r\n        display: flex;\r\n    }\r\n\r\n    .ui-button {\r\n        border-radius: 1rem;\r\n        box-shadow: 0.3rem 0.3rem 0.6rem var(--greyLight-2), -0.2rem -0.2rem 0.5rem var(--white);\r\n        justify-self: center;\r\n        display: -webkit-box;\r\n        display: flex;\r\n        -webkit-box-align: center;\r\n        align-items: center;\r\n        -webkit-box-pack: center;\r\n        justify-content: center;\r\n        cursor: pointer;\r\n        -webkit-transition: .3s ease;\r\n        transition: .3s ease;\r\n        background: var(--greyLight-1);\r\n        grid-column: 1 / 2;\r\n        grid-row: 5 / 6;\r\n        color: var(--greyDark);\r\n    }\r\n\r\n        .ui-button:hover {\r\n            color: var(--primary);\r\n        }\r\n\r\n        .ui-button:active {\r\n            box-shadow: inset 0.2rem 0.2rem 0.5rem var(--greyLight-2), inset -0.2rem -0.2rem 0.5rem var(--white);\r\n        }\r\n\r\n        .ui-button p {\r\n            font-size: 1.6rem;\r\n        }\r\n\r\n    .athleteDetails {\r\n        background-image: -webkit-linear-gradient(90deg, #8141D1 1.79%, #5628D9 98.81%);\r\n        -webkit-background-clip: text;\r\n        -webkit-text-fill-color: transparent;\r\n        color: linear-gradient(90deg, #8141D1 1.79%, #5628D9 98.81%);\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"text-center\"><h2>Power Scheduler</h2></div>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row p-2");
            __builder.AddMarkupContent(4, "\r\n    <h3></h3>\r\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "placeholder", "Search For Athletes Here");
            __builder.AddAttribute(7, "id", "nameSearch");
            __builder.AddAttribute(8, "type", "search");
            __builder.AddAttribute(9, "class", "beans");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 81 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                        SearchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchTerm = __value, SearchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "justify-ce");
            __builder.AddMarkupContent(16, "\r\n\r\n    ");
            __builder.OpenElement(17, "ul");
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 86 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
         if(!String.IsNullOrWhiteSpace(SearchTerm))
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
         foreach (Athlete athlete in FilteredAthletes)
        {


#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "        ");
            __builder.OpenElement(20, "li");
            __builder.AddContent(21, 
#nullable restore
#line 90 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
             athlete.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 91 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "row");
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-xl-6");
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenScheduler<EventAppt>>(32);
            __builder.AddAttribute(33, "Style", "height: 80%;");
            __builder.AddAttribute(34, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<EventAppt>>(
#nullable restore
#line 96 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                                                       evnts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "StartProperty", "Start");
            __builder.AddAttribute(36, "EndProperty", "End");
            __builder.AddAttribute(37, "TextProperty", "Text");
            __builder.AddAttribute(38, "AppointmentSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.SchedulerAppointmentSelectEventArgs<EventAppt>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.SchedulerAppointmentSelectEventArgs<EventAppt>>(this, 
#nullable restore
#line 96 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                                                                                                                                                                OnAppointmentSelect

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(39, "SlotSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.SchedulerSlotSelectEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.SchedulerSlotSelectEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                                                                                                                                                                                                  OnSlotSelectAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenMonthView>(42);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n        ");
            }
            ));
            __builder.AddComponentReferenceCapture(44, (__value) => {
#nullable restore
#line 96 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                                     scheduler = (Radzen.Blazor.RadzenScheduler<EventAppt>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "ui-button p-2 mr-1");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                                      AddAppointmentAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "Add New Appointment");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "class", "ui-button p-2 mr-1");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 100 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                                      GenerateReport

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Generate Report");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "  \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col-xl-6");
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(60);
            __builder.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(62, "\r\n            ");
                __builder2.OpenElement(63, "select");
                __builder2.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 104 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                           boundAthId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => boundAthId = __value, boundAthId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(66, "\r\n");
#nullable restore
#line 105 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                 foreach (var athlete in Athletes)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(67, "                ");
                __builder2.OpenElement(68, "option");
                __builder2.AddAttribute(69, "value", 
#nullable restore
#line 107 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                athlete.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(70, 
#nullable restore
#line 107 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                             athlete.FullName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n");
#nullable restore
#line 108 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(72, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.OpenElement(74, "div");
                __builder2.AddMarkupContent(75, "\r\n                Athlete\r\n                ");
                __builder2.OpenElement(76, "b");
                __builder2.AddContent(77, 
#nullable restore
#line 112 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                    currentAth.FullName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n\r\n            ");
                __builder2.OpenElement(80, "div");
                __builder2.AddMarkupContent(81, "\r\n                Appointment Times:\r\n\r\n");
#nullable restore
#line 118 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                 foreach (Appointment appts in currentAth.Appointments)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(82, "                ");
                __builder2.OpenElement(83, "b");
                __builder2.AddContent(84, 
#nullable restore
#line 120 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                    appts.Start

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n");
#nullable restore
#line 121 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(86, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenChart>(88);
                __builder2.AddAttribute(89, "Style", "width: 90%");
                __builder2.AddAttribute(90, "ColorScheme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.ColorScheme>(
#nullable restore
#line 124 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                                                          colorScheme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(92, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColumnSeries<Athlete>>(93);
                    __builder3.AddAttribute(94, "Stroke", "red");
                    __builder3.AddAttribute(95, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Athlete>>(
#nullable restore
#line 125 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                                        makeBarGraphHappy

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(96, "Title", "Bench");
                    __builder3.AddAttribute(97, "ValueProperty", "Bench");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(98, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColumnOptions>(99);
                    __builder3.AddAttribute(100, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 126 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                             5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenValueAxis>(102);
                    __builder3.AddAttribute(103, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 127 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                      0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(104, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 127 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                              600

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(105, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 127 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                                         100

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(106, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(107, "\r\n                    ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenCategoryAxis>(108);
                        __builder4.AddAttribute(109, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(110, "\r\n                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(111);
                            __builder5.AddAttribute(112, "Text", "BSD");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(113, "\r\n                    ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(114, "\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(115, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColumnSeries<Athlete>>(116);
                    __builder3.AddAttribute(117, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Athlete>>(
#nullable restore
#line 132 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                           makeBarGraphHappy

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(118, "Title", "Squat");
                    __builder3.AddAttribute(119, "ValueProperty", "Squat");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(120, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenValueAxis>(121);
                    __builder3.AddAttribute(122, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 133 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                      0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(123, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 133 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                              600

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(124, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 133 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                                         100

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(125, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColumnSeries<Athlete>>(126);
                    __builder3.AddAttribute(127, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Athlete>>(
#nullable restore
#line 134 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                           makeBarGraphHappy

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(128, "Title", "Deadlift");
                    __builder3.AddAttribute(129, "ValueProperty", "Deadlift");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(130, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenValueAxis>(131);
                    __builder3.AddAttribute(132, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 135 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                      0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(133, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 135 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                              600

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(134, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 135 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                                         100

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(135, "\r\n            ");
                }
                ));
                __builder2.AddComponentReferenceCapture(136, (__value) => {
#nullable restore
#line 124 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                               barChart = (Radzen.Blazor.RadzenChart)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(137, "\r\n            ");
                __builder2.OpenElement(138, "button");
                __builder2.AddAttribute(139, "class", "ui-button p-2 mr-1");
                __builder2.AddAttribute(140, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 137 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                                          AddAthlete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(141, "Add New Athlete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\r\n            ");
                __builder2.OpenElement(143, "button");
                __builder2.AddAttribute(144, "class", "ui-button p-2 mr-1");
                __builder2.AddAttribute(145, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 138 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                                          EditAthlete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(146, "Edit Athlete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\r\n\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(148, "\r\n\r\n        ");
            __builder.OpenComponent<PowerScheduler.Components.AddAthleteDialog>(149);
            __builder.AddComponentReferenceCapture(150, (__value) => {
#nullable restore
#line 142 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                AddAthleteDialog = (PowerScheduler.Components.AddAthleteDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(151, "\r\n\r\n        ");
            __Blazor.PowerScheduler.Pages.AppointmentOverview.TypeInference.CreateCascadingValue_0(__builder, 152, 153, 
#nullable restore
#line 144 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                currentAth.Id

#line default
#line hidden
#nullable disable
            , 154, "AthID", 155, (__builder2) => {
                __builder2.AddMarkupContent(156, "\r\n            ");
                __builder2.OpenComponent<PowerScheduler.Components.EditAthleteDialog>(157);
                __builder2.AddAttribute(158, "CloseEventCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 145 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                                                             AthleteDialog_OnDialogClose

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddComponentReferenceCapture(159, (__value) => {
#nullable restore
#line 145 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                     EditAthleteDialog = (PowerScheduler.Components.EditAthleteDialog)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(160, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(161, "\r\n\r\n        ");
            __builder.OpenComponent<PowerScheduler.Components.AddAppointment>(162);
            __builder.AddAttribute(163, "CloseEventCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 148 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                                                         AddAppointmentDialog_OnDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(164, (__value) => {
#nullable restore
#line 148 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                              AddAppointmentDialog = (PowerScheduler.Components.AddAppointment)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(165, "\r\n\r\n\r\n        ");
            __Blazor.PowerScheduler.Pages.AppointmentOverview.TypeInference.CreateCascadingValue_1(__builder, 166, 167, 
#nullable restore
#line 151 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                currentAthleteName

#line default
#line hidden
#nullable disable
            , 168, (__builder2) => {
                __builder2.AddMarkupContent(169, "\r\n            ");
                __Blazor.PowerScheduler.Pages.AppointmentOverview.TypeInference.CreateCascadingValue_2(__builder2, 170, 171, 
#nullable restore
#line 152 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                    currentAptId

#line default
#line hidden
#nullable disable
                , 172, "ApptID", 173, (__builder3) => {
                    __builder3.AddMarkupContent(174, "\r\n                ");
                    __builder3.OpenComponent<PowerScheduler.Components.EditAppointment>(175);
                    __builder3.AddAttribute(176, "CloseEventCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 153 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                                                                   AddAppointmentDialog_OnDialogClose

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddComponentReferenceCapture(177, (__value) => {
#nullable restore
#line 153 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                                       EditAppointmentDialog = (PowerScheduler.Components.EditAppointment)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(178, "\r\n            ");
                }
                );
                __builder2.AddMarkupContent(179, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(180, "\r\n        ");
            __builder.OpenComponent<PowerScheduler.Components.Report>(181);
            __builder.AddComponentReferenceCapture(182, (__value) => {
#nullable restore
#line 156 "C:\Users\Cole Bright\source\repos\PowerScheduler\Pages\AppointmentOverview.razor"
                      ReportDialog = (PowerScheduler.Components.Report)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(183, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoggerFactory LoggerFactory { get; set; }
    }
}
namespace __Blazor.PowerScheduler.Pages.AppointmentOverview
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateCascadingValue_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateCascadingValue_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
