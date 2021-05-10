using System;
using System.Collections.Generic;

namespace dotNet_project.Data
{
    public class ClientService : IClientService
    {
        private List<Client> clients = new List<Client>
        {
            new Client
            {
                Id = Guid.NewGuid(),
                Name = "AaronBison"
            },
            new Client
            {
                Id = Guid.NewGuid(),
                Name = "RailGummy"
            }
        };
        public List<Client> GetClients()
        {
            return clients;
        }
    }
}
