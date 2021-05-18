using DataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IEntriesData
    {
        Task<List<EntryModel>> GetEntries();
        Task InsertEntry(EntryModel entry);
    }
}