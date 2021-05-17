using DataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IPassesData
    {
        Task<List<PassModel>> GetPasses();
        PassModel GetPass(string passId);
        Task InsertPass(PassModel pass);
        Task UpdatePass(PassModel pass);
        Task DeletePass(PassModel pass);
    }
}