using TeamYankeeBLL.DTO;
using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL
{
    public interface IDataParser
    {
        Task InsertNationAsync(NationDescription nation);
        Task<List<NationDescription>> CollectNationsAsync();
        Task DeleteNationAsync(int NationId);
        IAsyncEnumerable<RosterBrief> CollectRosterBriefAsync();
    }
}