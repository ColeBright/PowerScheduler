#pragma checksum "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53fdb710940ceb95cd368b094a7fbba2592d729b"
// <auto-generated/>
#pragma warning disable 1591
namespace PowerScheduler.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 9 "C:\Users\Cole Bright\source\repos\PowerScheduler\_Imports.razor"
using PowerScheduler.Shared;

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
    public partial class EditAthleteDialog : EditAthleteBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
 if (ShowDialog)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show d-block");
            __builder.AddAttribute(3, "id", "exampleModal");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog");
            __builder.AddAttribute(9, "role", "document");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-content");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-header");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, "<h5 class=\"modal-title\" id=\"titleLabel\">Edit Athlete</h5>\r\n                    ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "close");
            __builder.AddAttribute(21, "data-dismiss", "modal");
            __builder.AddAttribute(22, "aria-label", "Close");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
                                                                                                          Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.AddMarkupContent(25, "<span aria-hidden=\"true\">&times;</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "modal-body");
            __builder.AddMarkupContent(30, "\r\n\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(31);
            __builder.AddAttribute(32, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
                                      Athlete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
                                                               HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(36);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(38);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n\r\n                        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "\r\n                            ");
                __builder2.AddMarkupContent(43, "<label for=\"FullName\">Full name: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "id", "FullName");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "placeholder", "Enter first name");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
                                                                                        Athlete.FullName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Athlete.FullName = __value, Athlete.FullName))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Athlete.FullName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                            ");
                __Blazor.PowerScheduler.Components.EditAthleteDialog.TypeInference.CreateValidationMessage_0(__builder2, 52, 53, 
#nullable restore
#line 25 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
                                                      () => Athlete.FullName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(54, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n                        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "\r\n                            ");
                __builder2.AddMarkupContent(59, "<label for=\"Bench\">Bench 1 rep max: </label>\r\n                            ");
                __Blazor.PowerScheduler.Components.EditAthleteDialog.TypeInference.CreateInputNumber_1(__builder2, 60, 61, "bench", 62, "form-control", 63, "Enter 1 rep max", 64, 
#nullable restore
#line 30 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
                                                                                       Athlete.Bench

#line default
#line hidden
#nullable disable
                , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Athlete.Bench = __value, Athlete.Bench)), 66, () => Athlete.Bench);
                __builder2.AddMarkupContent(67, "\r\n                            ");
                __Blazor.PowerScheduler.Components.EditAthleteDialog.TypeInference.CreateValidationMessage_2(__builder2, 68, 69, 
#nullable restore
#line 31 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
                                                      () => Athlete.Bench

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(70, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                        ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group");
                __builder2.AddMarkupContent(74, "\r\n                            ");
                __builder2.AddMarkupContent(75, "<label for=\"Squat\">Squat 1 rep max: </label>\r\n                            ");
                __Blazor.PowerScheduler.Components.EditAthleteDialog.TypeInference.CreateInputNumber_3(__builder2, 76, 77, "squat", 78, "form-control", 79, "Enter 1 rep max", 80, 
#nullable restore
#line 35 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
                                                                                       Athlete.Squat

#line default
#line hidden
#nullable disable
                , 81, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Athlete.Squat = __value, Athlete.Squat)), 82, () => Athlete.Squat);
                __builder2.AddMarkupContent(83, "\r\n                            ");
                __Blazor.PowerScheduler.Components.EditAthleteDialog.TypeInference.CreateValidationMessage_4(__builder2, 84, 85, 
#nullable restore
#line 36 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
                                                      () => Athlete.Squat

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(86, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-group");
                __builder2.AddMarkupContent(90, "\r\n                            ");
                __builder2.AddMarkupContent(91, "<label for=\"Deadlift\">Deadlift 1 rep max: </label>\r\n                            ");
                __Blazor.PowerScheduler.Components.EditAthleteDialog.TypeInference.CreateInputNumber_5(__builder2, 92, 93, "deadlift", 94, "form-control", 95, "Enter 1 rep max", 96, 
#nullable restore
#line 40 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
                                                                                          Athlete.Deadlift

#line default
#line hidden
#nullable disable
                , 97, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Athlete.Deadlift = __value, Athlete.Deadlift)), 98, () => Athlete.Deadlift);
                __builder2.AddMarkupContent(99, "\r\n                            ");
                __Blazor.PowerScheduler.Components.EditAthleteDialog.TypeInference.CreateValidationMessage_6(__builder2, 100, 101, 
#nullable restore
#line 41 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
                                                      () => Athlete.Deadlift

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(102, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n\r\n                        ");
                __builder2.AddMarkupContent(104, "<button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n                        ");
                __builder2.OpenElement(105, "a");
                __builder2.AddAttribute(106, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
                                                                      Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(108, "Close");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n");
#nullable restore
#line 46 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
                         if (Athlete.Id > 0)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(110, "                            ");
                __builder2.OpenElement(111, "a");
                __builder2.AddAttribute(112, "class", "btn btn-danger");
                __builder2.AddAttribute(113, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
                                                                 DeleteAthleteAsync

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(114, "\r\n                                Delete\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n");
#nullable restore
#line 51 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(116, "                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(117, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n");
#nullable restore
#line 58 "C:\Users\Cole Bright\source\repos\PowerScheduler\Components\EditAthleteDialog.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.PowerScheduler.Components.EditAthleteDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
