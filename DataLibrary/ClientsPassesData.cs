using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class ClientsPassesData : IClientsPassesData
    {
        private readonly IDataAcces _db;

        // Initialize database connection
        public ClientsPassesData(IDataAcces db)
        {
            _db = db;
        }

        // Get all Clients Passes
        public Task<List<ClientsPassesModel>> GetClientsPasses()
        {
            string sql = "SELECT * FROM clients_passes";

            return _db.LoadData<ClientsPassesModel, dynamic>(sql, new { });
        }

        // Get a specific Clients Pass
        public Task<List<ClientsPassesModel>> GetClientsPass(ClientModel client)
        {
            string sql = "SELECT * FROM clients_passes WHERE ClientId = @ClientId";

            return _db.LoadData<ClientsPassesModel, dynamic>(sql, client);
        }
        // Deletes Clients Pass
        public Task DeleteClientsPass(ClientsPassesModel clientsPass)
        {
            string sql = "DELETE FROM clients_passes WHERE (ClientsPassesId = @ClientsPassesId);";

            return _db.SaveData(sql, clientsPass);
        }
    }
}
