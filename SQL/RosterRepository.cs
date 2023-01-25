//using Microsoft.EntityFrameworkCore;
//using TeamYankeeBLL.SQL.Models;

//namespace TeamYankeeBLL.SQL
//{
//    internal class RosterRepository : IRosterRepository
//    {
//        public async Task<List<Nation>> GetAllNationsAsync()
//        {
//            using TeamYankeeContext db = new();
//            return await db.Nations.AsNoTracking().ToListAsync();
//        }
//        public async Task AddNation(Nation nation)
//        {
//            using TeamYankeeContext db = new();
//            db.Nations.Add(nation);
//            await db.SaveChangesAsync();
//        }
//        public async Task DeleteNation(int id)
//        {
//            using TeamYankeeContext db = new();
//            db.Nations.Remove(db.Nations.Where(n => n.Id == id).First());
//            await db.SaveChangesAsync();
//        }
//        public async Task UpdateNation(Nation nation)
//        {
//            using TeamYankeeContext db = new();
//            var curentNation = db.Nations.Where(n => n.Id == nation.Id).First();
//            curentNation.Name = nation.Name;
//            await db.SaveChangesAsync();
//        }

//        public async Task<List<Roster>> GetRostersDescryptionsAsync()
//        {
//            using TeamYankeeContext db = new();
//            return await db.Rosters.ToListAsync();
//        }
//        public async Task AddRoster(Roster roster)
//        {
//            using TeamYankeeContext db = new();
//            db.Rosters.Add(roster);
//            await db.SaveChangesAsync();
//        }
//        public async Task DeleteRosterAsync(int rosterId)
//        {
//            using TeamYankeeContext db = new();
//            db.Rosters.Remove(db.Rosters.AsNoTracking().Where(r => r.Id == rosterId).First());
//            await db.SaveChangesAsync();
//        }
//        public async Task UpdateRosterDescryptionAsync(Roster roster)
//        {
//            using TeamYankeeContext db = new();
//            var currentRoster = db.Rosters.Where(r => r.Id == roster.Id).First();

//            currentRoster.Name = roster.Name;
//            currentRoster.CurrentPoints = roster.CurrentPoints;
//            currentRoster.PointsLimit = roster.PointsLimit;
//            currentRoster.ReinforcementsLimit = roster.ReinforcementsLimit;
//            currentRoster.CurrentReinforcements = roster.CurrentReinforcements;
//            currentRoster.NationId = roster.NationId;

//            await db.SaveChangesAsync();
//        }

//        public async Task<List<RostersContent>> GetRosterContentAsync(int rosterId)
//        {
//            using TeamYankeeContext db = new();
//            return await db.RostersContents.AsNoTracking().Where(r => r.Id == rosterId).ToListAsync();
//        }
//        public async Task UpdateRosterContentAsync(RostersContent rosterContent)
//        {
//            using TeamYankeeContext db = new();
//            var currentRosterContent = db.RostersContents.Where(r => r.Id == rosterContent.Id).First();

//            currentRosterContent.RosterId = rosterContent.Id;
//            currentRosterContent.BlackBoxUnitId = rosterContent.BlackBoxUnitId;
//            currentRosterContent.FormationId = rosterContent.FormationId;

//            await db.SaveChangesAsync();
//        }
//        public async Task AddRosterContentAsync(RostersContent rostersContent)
//        {
//            using TeamYankeeContext db = new();
//            db.RostersContents.Add(rostersContent);
//            await db.SaveChangesAsync();
//        }
//        public async Task DeleteRosterContentAsync(int rosterContentId)
//        {
//            using TeamYankeeContext db = new();
//            db.RostersContents.Remove(db.RostersContents.AsNoTracking().Where(r => r.Id == rosterContentId).First());
//            await db.SaveChangesAsync();
//        }

//        public async Task<List<RostersSupportUnit>> GetRosterSupportUnitsAsync(int rosterId)
//        {
//            using TeamYankeeContext db = new();
//            return await db.RostersSupportUnits.Where(s => s.Id == rosterId).ToListAsync();
//        }
//        public async Task AddRosterSupportUnitAsync(RostersSupportUnit supportUnit)
//        {
//            using TeamYankeeContext db = new();
//            db.RostersSupportUnits.Add(supportUnit);
//            await db.SaveChangesAsync();
//        }
//        public async Task DeleteRosterRosterSupportUnitAsync(int supportId)
//        {
//            using TeamYankeeContext db = new();
//            db.RostersSupportUnits.Remove(db.RostersSupportUnits.AsNoTracking().Where(s => s.Id == supportId).First());
//            await db.SaveChangesAsync();
//        }
//        public async Task UpdateRosterSupportUnitAsync(RostersSupportUnit supportUnit)
//        {
//            using TeamYankeeContext db = new();
//            var currentSupport = db.RostersSupportUnits.Where(s => s.Id == supportUnit.Id).First();
//            currentSupport.RosterId = supportUnit.RosterId;
//            currentSupport.SuppotUnitId = supportUnit.SuppotUnitId;
//            await db.SaveChangesAsync();
//        }
//    }
//}
