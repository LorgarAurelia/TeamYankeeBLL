using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL.SQL
{
    public class UnitRepository : IUnitsRepository
    {
        public async IAsyncEnumerable<UsersUnit> GetUserUnitAsync(int[] listOfUnitId)
        {
            using TeamYankeeContext db = new();
            foreach (var id in listOfUnitId)
            {
                yield return await db.UsersUnits.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
            }
        }
        public async Task AddUserUnitAsync(UsersUnit unit)
        {
            using TeamYankeeContext db = new();
            db.UsersUnits.Add(unit);
            await db.SaveChangesAsync();
        }
        public async Task DeleteUserUnitAsync(UsersUnit unit)
        {
            using TeamYankeeContext db = new();
            db.UsersUnits.Remove(unit);
            await db.SaveChangesAsync();
        }
        public async Task UpdateUnitAsync(UsersUnit unit)
        {
            using TeamYankeeContext db = new();
            var currentUnit = db.UsersUnits.Where(u => u.Id == unit.Id).First();
            currentUnit = unit;       //TODO:
            await db.SaveChangesAsync();
        }


        public async Task<UnitsComposition> GetCompositionAsync(int referenceId)
        {
            using TeamYankeeContext db = new();
            return await db.UnitsCompositions.AsNoTracking().FirstOrDefaultAsync(r => r.Id == referenceId);
        }
        public async Task AddCompositionAsync(UnitsComposition composition)
        {
            using TeamYankeeContext db = new();
            db.UnitsCompositions.Add(composition);
            await db.SaveChangesAsync();
        }
        public async Task DeleteCompositionAsync(UnitsComposition composition)
        {
            using TeamYankeeContext db = new();
            db.UnitsCompositions.Remove(composition);
            await db.SaveChangesAsync();
        }
        public async Task UpdateCompositionAsync(UnitsComposition composition)
        {
            using TeamYankeeContext db = new();
            var currentComposition = db.UnitsCompositions.First(r => r.Id == composition.Id);
            currentComposition = composition; //TODO:
            await db.SaveChangesAsync();
        }


        public async Task<UnitsType> GetUnitTypeAsync(int referenceId)
        {
            using TeamYankeeContext db = new();
            return await db.UnitsTypes.FirstAsync(t => t.UnitId == referenceId);
        }
        public async Task AddUnitTypeAsync(UnitsType type)
        {
            using TeamYankeeContext db = new();
            db.UnitsTypes.Add(type);
            await db.SaveChangesAsync();
        }
        public async Task DeleteUnitTypeAsync(UnitsType type)
        {
            using TeamYankeeContext db = new();
            db.UnitsTypes.Remove(type);
            await db.SaveChangesAsync();
        }
        public async Task UpdateUnitTypeAsync(UnitsType type)
        {
            using TeamYankeeContext db = new();
            var currentType = db.UnitsTypes.First(t => t.Id == type.Id);
            currentType = type; //TODO:
            await db.SaveChangesAsync();
        }


        public async Task<UnitsReference> GetReferenceAsync(int referenceId)
        {
            using TeamYankeeContext db = new();
            return await db.UnitsReferences.AsNoTracking().FirstAsync(r => r.Id == referenceId);
        }
        public async Task AddReferenceAsync(UnitsReference reference)
        {
            using TeamYankeeContext db = new();
            db.UnitsReferences.Add(reference);
            await db.SaveChangesAsync();
        }
        public async Task DeleteReferenceAsync(UnitsReference reference)
        {
            using TeamYankeeContext db = new();
            db.UnitsReferences.Remove(reference);
            await db.SaveChangesAsync();
        }
        public async Task UpdateReferenceAsync(UnitsReference reference)
        {
            using TeamYankeeContext db = new();
            var currrentReference = db.UnitsReferences.First(t => t.Id == reference.Id);
            currrentReference = reference; //TODO:
            await db.SaveChangesAsync();
        }
    }
}
