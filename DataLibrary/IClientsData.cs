using DataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IClientsData
    {
        Task<List<ClientModel>> GetClients();
        ClientModel GetClientById(string clientId);
        Task InsertClient(ClientModel client);
        Task UpdateClient(ClientModel client);
        Task DeleteClient(ClientModel client);
        InfoClientModel GetClientInfoByBarCode(string clientBarCode);
        ClientModel GetClientByBarCode(string BarCode);
    }
}