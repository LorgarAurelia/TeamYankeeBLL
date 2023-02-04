using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL.SQL
{
    internal interface IRosterRepository
    {
        Task<List<Nation>> GetAllNationsAsync();
        Task AddNation(Nation nation);
        Task DeleteNation(Nation nation);
        Task UpdateNation(Nation nation);

        Task<List<RosterDescription>> GetRostersDescryptionsAsync(); //TODO: Входной параметр userId 
        Task AddRoster(RosterDescription roster);
        Task DeleteRosterAsync(RosterDescription roster);
        Task UpdateRosterDescryptionAsync(RosterDescription roster);

        Task<List<RostersContent>> GetRosterContentAsync(int rosterId);
        Task UpdateRosterContentAsync(RostersContent rosterContent);
        Task AddRosterContentAsync(RostersContent rostersContent);
        Task DeleteRosterContentAsync(RostersContent rostersContent);

        Task<List<RostersSupportUnit>> GetRosterSupportUnitsAsync(int rosterId);
        Task AddRosterSupportUnitAsync(RostersSupportUnit supportUnit);
        Task DeleteRosterRosterSupportUnitAsync(RostersSupportUnit supportUnit);
        Task UpdateRosterSupportUnitAsync(RostersSupportUnit supportUnit);
    }
}
