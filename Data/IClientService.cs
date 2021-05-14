using dotNet_project.Models;
using System.Collections.Generic;

namespace dotNet_project.Data
{
    interface IClientService
    {
        List<ClientModel> GetClients();
    }
}
