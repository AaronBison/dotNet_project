using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class ClientsData : IClientsData
    {
        private readonly IDataAcces _db;

        // Initialize database connection
        public ClientsData(IDataAcces db)
        {
            _db = db;
        }

        // Get all Clients
        public Task<List<ClientModel>> GetClients()
        {
            string sql = "SELECT * FROM clients";

            return _db.LoadData<ClientModel, dynamic>(sql, new { });
        }

        // Get a Client by Id
        public ClientModel GetClientById(string clientId)
        {
            string sql = "SELECT * FROM clients WHERE ClientId = " + clientId;

            return _db.LoadData<ClientModel, dynamic>(sql, new { }).Result[0];
        }

        // Inserts Client
        public Task InsertClient(ClientModel client)
        {
            string sql = "INSERT INTO clients (Name, PhoneNumber, EmailAddress, is_deleted, CreatedDate, CNP, Address, BarCode, Notes) VALUES (@Name, @PhoneNumber, @EmailAddress, @is_deleted, @CreatedDate, @CNP, @Address, @BarCode, @Notes);";

            return _db.SaveData(sql, client);
        }

        // Updates Client
        public Task UpdateClient(ClientModel client)
        {
            string sql = "UPDATE clients SET Name = @Name, PhoneNumber = @PhoneNumber, EmailAddress = @EmailAddress, CNP = @CNP, Address = @Address, Notes = @Notes WHERE (ClientId = @ClientId);";
            return _db.SaveData(sql, client);
        }


        // Deletes Client
        public Task DeleteClient(ClientModel client)
        {
            string sql = "DELETE FROM clients WHERE (ClientId = @ClientId);";

            return _db.SaveData(sql, client);
        }

        // Get Client Info by BarCode
        public InfoClientModel GetClientInfoByBarCode(string clientBarCode)
        {
            string sql = "SELECT c.ClientId ,c.Name, c.PhoneNumber, c.EmailAddress, c.is_deleted, c.Photo, c.CreatedDate, c.CNP, c.Address, c.BarCode, c.Notes, count(*) as NumberOfPasses, IF(isActive = 1, 1, NULL) as HasActivePass, DATE_ADD(cp.BuyDate, INTERVAL pt.DaysUntilExpires DAY) as PassExpiration FROM clients c join clients_passes cp on c.ClientId = cp.ClientId join pass_types pt on cp.PassId = pt.PassId where c.BarCode = " + clientBarCode;

            return _db.LoadData<InfoClientModel, dynamic>(sql, new { }).Result[0];
        }

        // Get Client by BarCode
        public ClientModel GetClientByBarCode(string BarCode)
        {
            string sql = "SELECT * FROM clients WHERE BarCode = " + BarCode;

            Task<List<ClientModel>> c = _db.LoadData<ClientModel, dynamic>(sql, new { });
            if (c.Result.Count != 0)
            {
                return c.Result[0];
            }
            else
            {
                return null;
            }
        }
    }
}
