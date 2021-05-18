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
    }
}