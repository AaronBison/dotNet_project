using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IDataAcces
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameteres);
        Task<List<T>> LoadData<T, U>(string sql, U parameteres, string connectionString);
        Task SaveData<T>(string sql, T parameteres);
        Task SaveData<T>(string sql, T parameteres, string connectionString);
    }
}