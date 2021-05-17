using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class PassesData : IPassesData
    {
        private readonly IDataAcces _db;

        // Initialize database connection
        public PassesData(IDataAcces db)
        {
            _db = db;
        }

        // Get all Passes
        public Task<List<PassModel>> GetPasses()
        {
            string sql = "SELECT * FROM pass_types";

            return _db.LoadData<PassModel, dynamic>(sql, new { });
        }

        // Get a specific Pass
        public PassModel GetPass(string passId)
        {
            string sql = "SELECT * FROM pass_types WHERE PassId = " + passId;

            return _db.LoadData<PassModel, dynamic>(sql, new { }).Result[0];
        }

        // Updates Pass
        public Task UpdatePass(PassModel pass)
        {
            string sql = "UPDATE pass_types SET PassName = @PassName, Price = @Price, DaysUntilExpires = @DaysUntilExpires, EntriesUntilExpires = @EntriesUntilExpires, is_deleted = @is_deleted, HallId = @HallId, HourUntil = @HourUntil, HourUntil = @HourUntil, UsablePerDay = @UsablePerDay WHERE (PassId = @PassId);";
            return _db.SaveData(sql, pass);
        }

        // Inserts Pass
        public Task InsertPass(PassModel pass)
        {
            string sql = "INSERT INTO pass_types (PassName, Price, DaysUntilExpires, EntriesUntilExpires, is_deleted, HallId, HourFrom, HourUntil, UsablePerDay) VALUES (@PassName, @Price, @DaysUntilExpires, @EntriesUntilExpires, @is_deleted, @HallId, @HourFrom, @HourUntil, @UsablePerDay);";

            return _db.SaveData(sql, pass);
        }

        // Deletes Pass
        public Task DeletePass(PassModel pass)
        {
            string sql = "DELETE FROM pass_types WHERE (PassId = @PassId);";

            return _db.SaveData(sql, pass);
        }
    }
}
