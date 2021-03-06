using DataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IClientsPassesData
    {
        Task<List<ClientsPassesModel>> GetClientsPass(ClientModel clientId);
        Task<List<ClientsPassesModel>> GetClientsPasses();
        Task DeleteClientsPass(ClientsPassesModel clientsPass);
        Task InsertClientsPass(ClientsPassesModel clientsPass);
        Task<List<InfoClientsPassModel>> GetInfoClientsPass(InfoClientModel client);
        Task UpdateClientsEntriesCount(ClientsPassesModel clientsPass);
        Task ActivateClientsPass(ClientsPassesModel clientsPass);
        Task DeactivateAllClientsPasses(ClientsPassesModel clientsPass);
    }
}