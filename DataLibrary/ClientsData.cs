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

        // Get a specific Client
        public ClientModel GetClient(string clientId)
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
    }
}
