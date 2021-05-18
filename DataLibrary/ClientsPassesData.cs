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

        // Insert Clients Pass connection
        public Task InsertClientsPass(ClientsPassesModel clientsPass)
        {
            string sql = "INSERT INTO clients_passes (ClientId, PassId, BuyDate, BarCode, EntriesCount, BuyPrice, IsActive, FirstUsageDate, HallId) VALUES (@ClientId, @PassId, @BuyDate, @BarCode, @EntriesCount, @BuyPrice, @IsActive, @FirstUsageDate, @HallId);";

            return _db.SaveData(sql, clientsPass);
        }

        // Gets active Info Clients Pass
        public Task<List<InfoClientsPassModel>> GetInfoClientsPass(InfoClientModel client)
        {
            string sql = "SELECT cp.ClientsPassesId, cp.ClientId, cp.PassId, cp.BuyDate, cp.BarCode, cp.EntriesCount, cp.IsActive, cp.HallId, pt.PassName, pt.DaysUntilExpires, pt.EntriesUntilExpires, pt.HourFrom, pt.HourUntil, pt.UsablePerDay, DATEDIFF(DATE_ADD(cp.BuyDate, INTERVAL pt.DaysUntilExpires DAY), CURDATE()) as DaysLeft FROM clients_passes cp join pass_types pt on cp.PassId = pt.PassId WHERE cp.BarCode = @BarCode AND cp.IsActive = 1;";

            return _db.LoadData<InfoClientsPassModel, dynamic>(sql, client);
        }

        public Task UpdateClientsEntriesCount(ClientsPassesModel clientsPass)
        {
            string sql = "UPDATE clients_passes SET EntriesCount = @EntriesCount WHERE (ClientsPassesId = @ClientsPassesId);";
            return _db.SaveData(sql, clientsPass);
        }
   }
}
