using Microsoft.EntityFrameworkCore;
using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL.SQL
{
    internal class RosterRepository : IRosterRepository
    {
        public async Task<List<Nation>> GetAllNationsAsync()
        {
            using TeamYankeeContext db = new();
            return await db.Nations.AsNoTracking().ToListAsync();
        }
        public async Task AddNation(Nation nation)
        {
            using TeamYankeeContext db = new();
            db.Nations.Add(nation);
            await db.SaveChangesAsync();
        }
        public async Task DeleteNation(Nation nation)
        {
            using TeamYankeeContext db = new();
            db.Nations.Remove(nation);
            await db.SaveChangesAsync();
        }
        public async Task UpdateNation(Nation nation)
        {
            using TeamYankeeContext db = new();
            var curentNation = db.Nations.Where(n => n.Id == nation.Id).First();
            curentNation.Name = nation.Name;
            await db.SaveChangesAsync();
        }

        public async Task<List<RosterDescription>> GetRostersDescryptionsAsync()
        {
            using TeamYankeeContext db = new();
            return await db.Rosters.ToListAsync();
        }
        public async Task AddRoster(RosterDescription roster)
        {
            using TeamYankeeContext db = new();
            db.Rosters.Add(roster);
            await db.SaveChangesAsync();
        }
        public async Task DeleteRosterAsync(RosterDescription roster)
        {
            using TeamYankeeContext db = new();
            db.Rosters.Remove(roster);
            await db.SaveChangesAsync();
        }
        public async Task UpdateRosterDescryptionAsync(RosterDescription roster)
        {
            using TeamYankeeContext db = new();
            var currentRoster = db.Rosters.Where(r => r.Id == roster.Id).First();

            currentRoster.Name = roster.Name;
            currentRoster.CurrentPoints = roster.CurrentPoints;
            currentRoster.PointsLimit = roster.PointsLimit;
            currentRoster.ReinforcementsLimit = roster.ReinforcementsLimit;
            currentRoster.CurrentReinforcements = roster.CurrentReinforcements;
            currentRoster.NationId = roster.NationId;

            await db.SaveChangesAsync();
        }

        public async Task<List<RostersContent>> GetRosterContentAsync(int rosterId)
        {
            using TeamYankeeContext db = new();
            return await db.RostersContents.AsNoTracking().Where(r => r.Id == rosterId).ToListAsync();
        }
        public async Task UpdateRosterContentAsync(RostersContent rosterContent)
        {
            using TeamYankeeContext db = new();
            var currentRosterContent = db.RostersContents.Where(r => r.Id == rosterContent.Id).First();

            currentRosterContent.RosterId = rosterContent.Id;
            currentRosterContent.BlackBoxUnitId = rosterContent.BlackBoxUnitId;
            currentRosterContent.FormationId = rosterContent.FormationId;

            await db.SaveChangesAsync();
        }
        public async Task AddRosterContentAsync(RostersContent rostersContent)
        {
            using TeamYankeeContext db = new();
            db.RostersContents.Add(rostersContent);
            await db.SaveChangesAsync();
        }
        public async Task DeleteRosterContentAsync(RostersContent rostersContent)
        {
            using TeamYankeeContext db = new();
            db.RostersContents.Remove(rostersContent);
            await db.SaveChangesAsync();
        }

        public async Task<List<RostersSupportUnit>> GetRosterSupportUnitsAsync(int rosterId)
        {
            using TeamYankeeContext db = new();
            return await db.RostersSupportUnits.Where(s => s.Id == rosterId).ToListAsync();
        }
        public async Task AddRosterSupportUnitAsync(RostersSupportUnit supportUnit)
        {
            using TeamYankeeContext db = new();
            db.RostersSupportUnits.Add(supportUnit);
            await db.SaveChangesAsync();
        }
        public async Task DeleteRosterRosterSupportUnitAsync(RostersSupportUnit supportUnit)
        {
            using TeamYankeeContext db = new();
            db.RostersSupportUnits.Remove(supportUnit);
            await db.SaveChangesAsync();
        }
        public async Task UpdateRosterSupportUnitAsync(RostersSupportUnit supportUnit)
        {
            using TeamYankeeContext db = new();
            var currentSupport = db.RostersSupportUnits.Where(s => s.Id == supportUnit.Id).First();
            currentSupport.RosterId = supportUnit.RosterId;
            currentSupport.SuppotUnitId = supportUnit.SuppotUnitId;
            await db.SaveChangesAsync();
        }
    }
}
