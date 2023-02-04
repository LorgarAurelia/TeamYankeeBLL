using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL.SQL
{
    public class FormationRepository : IFormationsRepository
    {
        public async IAsyncEnumerable<UsersFormation> GetRosterFormationAsync(List<int> listOfId) 
        {
            using TeamYankeeContext db = new();
            foreach (var id in listOfId)
            {
                yield return await db.UsersFormations.AsNoTracking().Where(u => u.Id == id).FirstAsync();
            }
        }
        public async Task AddFormationToRosterAsync(UsersFormation formation)
        {
            using TeamYankeeContext db = new();
            db.UsersFormations.Add(formation);
            await db.SaveChangesAsync();
        }
        public async Task DeleteFormationFromRosterAsync(UsersFormation formation)
        {
            using TeamYankeeContext db = new();
            db.UsersFormations.Remove(formation);
            await db.SaveChangesAsync();
        }
        public async Task UpdateFormationAsync(UsersFormation formation)
        {
            using TeamYankeeContext db = new();
            var currentFormation = db.UsersFormations.Where(u => u.Id == formation.Id).First();
            currentFormation = formation; //TODO: проверить как выполняется.
            await db.SaveChangesAsync();
        }


        public async Task<List<FormationsAsset>> GetAssetsAsync(int formationId)
        {
            using TeamYankeeContext db = new();
            return await db.FormationsAssets.AsNoTracking().Where(f => f.FormationId == formationId).ToListAsync();
        }
        public async Task AddAssetAsync(FormationsAsset asset)
        {
            using TeamYankeeContext db = new();
            db.FormationsAssets.Add(asset);
            await db.SaveChangesAsync();
        }
        public async Task DeleteAssetAsync(FormationsAsset asset)
        {
            using TeamYankeeContext db = new();
            db.Remove(asset);
            await db.SaveChangesAsync();
        }
        public async Task UpdateAssetAsync(FormationsAsset asset) 
        {
            using TeamYankeeContext db = new();
            var currentAsset = db.FormationsAssets.Where(f => f.Id == asset.Id).First();
            currentAsset = asset; //TODO:
            await db.SaveChangesAsync();
        }


        public async Task<List<FormationsComposition>> GetCompositionAsync(int referenceId)
        {
            using TeamYankeeContext db = new();
            return await db.FormationsCompositions.AsNoTracking().Where(fc => fc.Id == referenceId).ToListAsync();
        }
        public async Task AddCompositionAsync(FormationsComposition composition)
        {
            using TeamYankeeContext db = new();
            db.Add(composition);
            await db.SaveChangesAsync();
        }
        public async Task DeleteCompositionAsync(FormationsComposition composition)
        {
            using TeamYankeeContext db = new();
            db.Remove(composition);
            await db.SaveChangesAsync();
        }
        public async Task UpdateCompositionAsync(FormationsComposition composition)
        {
            using TeamYankeeContext db = new();
            var currentComposition = db.FormationsCompositions.Where(fc => fc.Id == composition.Id).First();
            currentComposition = composition; //TODO:
            await db.SaveChangesAsync();
        }


        public async Task<List<FormationsReference>> GetFormaionReferencesAsync(int nationId)
        {
            using TeamYankeeContext db = new();
            return await db.FormationsReferences.AsNoTracking().Where(fr => fr.NationId == nationId).ToListAsync();
        } 
        public async Task AddFormationReferenceAsync(FormationsReference reference)
        {
            using TeamYankeeContext db = new();
            db.FormationsReferences.Add(reference);
            await db.SaveChangesAsync();
        }
        public async Task DeleteFormationReferenceAsync(FormationsReference reference)
        {
            using TeamYankeeContext db = new();
            db.FormationsReferences.Remove(reference);
            await db.SaveChangesAsync();
        }
        public async Task UpdateFormationReferenceAsync(FormationsReference reference)
        {
            using TeamYankeeContext db = new();
            var currentReference = db.FormationsReferences.First(fr => fr.Id == reference.Id);//TODO: проверить корректность записи
            currentReference = reference; //TODO:
            await db.SaveChangesAsync();
        }
    }
}
