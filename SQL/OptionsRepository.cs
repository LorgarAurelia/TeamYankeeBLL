using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL.SQL
{
    internal class OptionsRepository : IOptionsRepository
    {
        public async Task AddOptionReferenceAsync(UnitsOptionsReference reference)
        {
            using TeamYankeeContext db = new();
            db.UnitsOptionsReferences.Add(reference);
            await db.SaveChangesAsync();
        }

        public async Task AddUserUnitOption(UsersUnitsOption unitOption)
        {
            using TeamYankeeContext db = new();
            db.UsersUnitsOptions.Add(unitOption);
            await db.SaveChangesAsync();
        }

        public async Task DeleteOptionReferenceAsync(UnitsOptionsReference refrence)
        {
            using TeamYankeeContext db = new();
            db.UnitsOptionsReferences.Remove(refrence);
            await db.SaveChangesAsync();
        }

        public async Task DeleteUserUnitOption(UsersUnitsOption unit)
        {
            using TeamYankeeContext db = new();
            db.UsersUnitsOptions.Remove(unit);
            await db.SaveChangesAsync();
        }

        public async Task<UnitsOptionsReference> GetOptionReferenceAsync(int referenceId)
        {
            using TeamYankeeContext db = new();
            return await db.UnitsOptionsReferences.FirstAsync(r => r.UnitId == referenceId);
        }

        public async Task<List<UsersUnitsOption>> GetUnitOptionsAsync(int unitId)
        {
            using TeamYankeeContext db = new();
            return await db.UsersUnitsOptions.AsNoTracking().ToListAsync();
        }

        public async Task UpdateOptionReferenceAsync(UnitsOptionsReference reference)
        {
            using TeamYankeeContext db = new();
            var currentReference = db.UnitsOptionsReferences.Where(r => r.Id == reference.Id).First();
            currentReference.UnitId = reference.UnitId;
            currentReference.Option = reference.Option;
            currentReference.Price = reference.Price;
            currentReference.OptionLimit = reference.OptionLimit;
            currentReference.IsForAll = reference.IsForAll;
            await db.SaveChangesAsync();
        }

        public async Task UpdateUserUnitOption(UsersUnitsOption unitOption)
        {
            using TeamYankeeContext db = new();
            var current = db.UsersUnitsOptions.Where(uu => uu.Id == unitOption.Id).First();
            current.UnitId = unitOption.UnitId;
            current.ReferenceId = unitOption.ReferenceId;
            current.Count = unitOption.Count;
            current.Cost = unitOption.Cost;
            await db.SaveChangesAsync();
        }
    }
}
