using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class DataAcces : IDataAcces
    {
        private readonly IConfiguration _config;
        public string ConnectionStringName { get; set; } = "Default";

        public DataAcces(IConfiguration config)
        {
            _config = config;
        }

        // LoadData
        public async Task<List<T>> LoadData<T, U>(string sql, U parameteres)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(sql, parameteres);

                return rows.ToList();
            }
        }

        // SaveData
        public async Task SaveData<T>(string sql, T parameteres)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameteres);
            }
        }

        public Task<List<T>> LoadData<T, U>(string sql, U parameteres, string connectionString)
        {
            throw new NotImplementedException();
        }

        public Task SaveData<T>(string sql, T parameteres, string connectionString)
        {
            throw new NotImplementedException();
        }
    }
}
