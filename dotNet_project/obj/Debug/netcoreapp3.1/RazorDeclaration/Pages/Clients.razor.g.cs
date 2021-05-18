// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace dotNet_project.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 3 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Clients.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Clients.razor"
using DataLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Clients.razor"
using dotNet_project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Clients.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/clients")]
    public partial class Clients : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "D:\-EMTE-\4.ev\4_II\.NET\dotNet_project\dotNet_project\dotNet_project\Pages\Clients.razor"
       

    private List<ClientModel> clients;
    private DisplayClientModel newClient = new DisplayClientModel();

    protected override async Task OnInitializedAsync()
    {
        clients = await _db.GetClients();
    }

    private async Task InsertClient()
    {
        Random rd = new Random();
        int bar_code = rd.Next(1000, 9999);

        ClientModel c = new ClientModel
        {
            Name = newClient.Name,
            PhoneNumber = newClient.PhoneNumber,
            EmailAddress = newClient.EmailAddress,
            is_deleted = false,
            CNP = newClient.CNP,
            CreatedDate = DateTime.UtcNow.ToString("yyyy-MM-dd"),
            Address = newClient.Address,
            BarCode = bar_code.ToString(),
            Notes = newClient.Notes,
        };
        await _db.InsertClient(c);

        await OnInitializedAsync();

        newClient = new DisplayClientModel();
    }

    private async Task DeleteClient(ClientModel client)
    {
        await _db.DeleteClient(client);

        await OnInitializedAsync();
    }

    void MoveToModifyPage(ClientModel client)
    {
        NavigationManager.NavigateTo("/clients/" + client.ClientId);
    }

    void MoveToClientsPassesPage(ClientModel client)
    {
        NavigationManager.NavigateTo("/clients/passes/" + client.ClientId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientsData _db { get; set; }
    }
}
#pragma warning restore 1591
