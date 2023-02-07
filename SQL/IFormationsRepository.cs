using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL.SQL
{
    public interface IFormationsRepository
    {
        IAsyncEnumerable<UsersFormation> GetRosterFormationAsync(int[] listOfId);
        Task AddFormationToRosterAsync(UsersFormation formation);
        Task DeleteFormationFromRosterAsync(UsersFormation formation);
        Task UpdateFormationAsync(UsersFormation formation);

        Task<List<FormationsAsset>> GetAssetsAsync(int formationId);
        Task AddAssetAsync(FormationsAsset asset);
        Task DeleteAssetAsync(FormationsAsset asset);
        Task UpdateAssetAsync(FormationsAsset asset);

        Task<List<FormationsReference>> GetFormaionReferencesAsync(int nationId);
        Task AddFormationReferenceAsync(FormationsReference reference);
        Task DeleteFormationReferenceAsync(FormationsReference reference);
        Task UpdateFormationReferenceAsync(FormationsReference reference);

        Task<List<FormationsComposition>> GetCompositionAsync(int referenceId);
        Task AddCompositionAsync(FormationsComposition composition);
        Task DeleteCompositionAsync(FormationsComposition composition);
        Task UpdateCompositionAsync(FormationsComposition composition);

    }
}
