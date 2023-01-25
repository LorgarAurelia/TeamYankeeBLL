using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL.SQL
{
    internal interface IRosterRepository
    {
        Task<List<Nation>> GetAllNationsAsync();
        Task AddNation(Nation nation);
        Task DeleteNation(int id);
        Task UpdateNation(Nation nation);

        Task<List<RosterDescription>> GetRostersDescryptionsAsync(); //TODO: Входной параметр userId 
        Task AddRoster(RosterDescription roster);
        Task DeleteRosterAsync(int rosterId);
        Task UpdateRosterDescryptionAsync(RosterDescription roster);

        Task<List<RostersContent>> GetRosterContentAsync(int rosterId);
        Task UpdateRosterContentAsync(RostersContent rosterContent);
        Task AddRosterContentAsync(RostersContent rostersContent);
        Task DeleteRosterContentAsync(int rosterContentId);

        Task<List<RostersSupportUnit>> GetRosterSupportUnitsAsync(int rosterId);
        Task AddRosterSupportUnitAsync(RostersSupportUnit supportUnit);
        Task DeleteRosterRosterSupportUnitAsync(int supportId);
        Task UpdateRosterSupportUnitAsync(RostersSupportUnit supportUnit);
    }
}
