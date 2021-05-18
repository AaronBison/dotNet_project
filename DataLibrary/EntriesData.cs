using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class EntriesData : IEntriesData
    {
        private readonly IDataAcces _db;
        // Initialize database connection
        public EntriesData(IDataAcces db)
        {
            _db = db;
        }

        // Get all Entries
        public Task<List<EntryModel>> GetEntries()
        {
            string sql = "SELECT e.EntryId, c.Name, e.PassId, e.Date, e.InsertedBy, e.BarCode, e.HallId FROM entries e join clients c on e.ClientId = c.ClientId;";

            return _db.LoadData<EntryModel, dynamic>(sql, new { });
        }
    }
}
