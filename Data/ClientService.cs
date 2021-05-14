using dotNet_project.Models;
using System;
using System.Collections.Generic;

namespace dotNet_project.Data
{
    public class ClientService : IClientService
    {
        private List<ClientModel> clients = new List<ClientModel>
        {
            new ClientModel
            {
                FirstName = "Aaron",
                LastName = "Bison"
            },
            new ClientModel
            {
                FirstName = "Thomas",
                LastName = "Bison"
            },
        };
        public List<ClientModel> GetClients()
        {
            return clients;
        }
    }
}
