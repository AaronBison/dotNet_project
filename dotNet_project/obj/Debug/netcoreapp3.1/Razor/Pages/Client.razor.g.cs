#pragma checksum "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Client.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22dc4a2faeffff952f114d473d0e9f9eb5f284e1"
// <auto-generated/>
#pragma warning disable 1591
namespace dotNet_project.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\_Imports.razor"
using dotNet_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\_Imports.razor"
using dotNet_project.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Client.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Client.razor"
using DataLibrary.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/clients/{id}")]
    public partial class Client : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, "Edit ");
            __builder.AddContent(3, 
#nullable restore
#line 10 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Client.razor"
          client.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n<hr>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Client.razor"
                 client

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Client.razor"
                                    UpdateClient

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "style", "width:400px;");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n\r\n    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.AddMarkupContent(14, "<h6><b>Client ID</b></h6>\r\n        ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "id", "id");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "value", 
#nullable restore
#line 17 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Client.razor"
                                                    client.ClientId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(19, "readonly", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n\r\n    ");
                __builder2.OpenElement(22, "table");
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenElement(24, "tbody");
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.OpenElement(26, "tr");
                __builder2.AddMarkupContent(27, "\r\n                ");
                __builder2.OpenElement(28, "td");
                __builder2.AddMarkupContent(29, "\r\n                    ");
                __builder2.AddMarkupContent(30, "<h6><b>Client Name</b></h6>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "class", "form-control");
                __builder2.AddAttribute(33, "style", "margin: 10px;");
                __builder2.AddAttribute(34, "placeholder", "Name");
                __builder2.AddAttribute(35, "id", "name");
                __builder2.AddAttribute(36, "Label", "Name");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Client.razor"
                                                                                                                    client.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => client.Name = __value, client.Name))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => client.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                ");
                __builder2.OpenElement(42, "td");
                __builder2.AddMarkupContent(43, "\r\n                    ");
                __builder2.AddMarkupContent(44, "<h6><b>Phone number</b></h6>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "style", "margin: 10px;");
                __builder2.AddAttribute(48, "placeholder", "Phone Number");
                __builder2.AddAttribute(49, "id", "phonenumber");
                __builder2.AddAttribute(50, "Label", "Phone Number");
                __builder2.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Client.razor"
                                                                                                                                   client.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => client.PhoneNumber = __value, client.PhoneNumber))));
                __builder2.AddAttribute(53, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => client.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.OpenElement(57, "tr");
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.OpenElement(59, "td");
                __builder2.AddMarkupContent(60, "\r\n                    ");
                __builder2.AddMarkupContent(61, "<h6><b>Email address</b></h6>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(62);
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "style", "margin: 10px;");
                __builder2.AddAttribute(65, "placeholder", "Email Address");
                __builder2.AddAttribute(66, "id", "emailaddress");
                __builder2.AddAttribute(67, "Label", "EmailAddress");
                __builder2.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Client.razor"
                                                                                                                                     client.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => client.EmailAddress = __value, client.EmailAddress))));
                __builder2.AddAttribute(70, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => client.EmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                ");
                __builder2.OpenElement(73, "td");
                __builder2.AddMarkupContent(74, "\r\n                    ");
                __builder2.AddMarkupContent(75, "<h6><b>CNP</b></h6>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(76);
                __builder2.AddAttribute(77, "class", "form-control");
                __builder2.AddAttribute(78, "style", "margin: 10px;");
                __builder2.AddAttribute(79, "placeholder", "CNP");
                __builder2.AddAttribute(80, "id", "cnp");
                __builder2.AddAttribute(81, "Label", "CNP");
                __builder2.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Client.razor"
                                                                                                                  client.CNP

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => client.CNP = __value, client.CNP))));
                __builder2.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => client.CNP));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n            ");
                __builder2.OpenElement(88, "tr");
                __builder2.AddMarkupContent(89, "\r\n                ");
                __builder2.OpenElement(90, "td");
                __builder2.AddMarkupContent(91, "\r\n                    ");
                __builder2.AddMarkupContent(92, "<h6><b>Address</b></h6>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(93);
                __builder2.AddAttribute(94, "class", "form-control");
                __builder2.AddAttribute(95, "style", "margin: 10px;");
                __builder2.AddAttribute(96, "placeholder", "Address");
                __builder2.AddAttribute(97, "id", "address");
                __builder2.AddAttribute(98, "Label", "Address");
                __builder2.AddAttribute(99, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Client.razor"
                                                                                                                          client.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(100, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => client.Address = __value, client.Address))));
                __builder2.AddAttribute(101, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => client.Address));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(102, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                ");
                __builder2.OpenElement(104, "td");
                __builder2.AddMarkupContent(105, "\r\n                    ");
                __builder2.AddMarkupContent(106, "<h6><b>Notes</b></h6>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(107);
                __builder2.AddAttribute(108, "class", "form-control");
                __builder2.AddAttribute(109, "style", "margin: 10px;");
                __builder2.AddAttribute(110, "placeholder", "Notes");
                __builder2.AddAttribute(111, "id", "notes");
                __builder2.AddAttribute(112, "Label", "Notes");
                __builder2.AddAttribute(113, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Client.razor"
                                                                                                                      client.Notes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => client.Notes = __value, client.Notes))));
                __builder2.AddAttribute(115, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => client.Notes));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(116, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n\r\n    ");
                __builder2.AddMarkupContent(121, "<button type=\"submit\" class=\"btn btn-primary\">Update</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Client.razor"
       
    [Parameter]
    public string Id { get; set; }

    private ClientModel client;

    protected override void OnInitialized()
    {
        client = _db.GetClient(Id);
    }

    private void UpdateClient()
    {
        _db.UpdateClient(client);
        NavigationManager.NavigateTo("/clients");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientsData _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
