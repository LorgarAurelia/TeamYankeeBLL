using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL.SQL
{
    internal interface IUnitsRepository
    {
        IAsyncEnumerable<UsersUnit> GetUserUnitAsync(int[] listOfUnitId);
        Task AddUserUnitAsync(UsersUnit unit);
        Task DeleteUserUnitAsync(UsersUnit unit);
        Task UpdateUnitAsync(UsersUnit unit);

        Task<UnitsComposition> GetCompositionAsync(int referenceId);
        Task AddCompositionAsync(UnitsComposition composition);
        Task DeleteCompositionAsync(UnitsComposition composition);
        Task UpdateCompositionAsync(UnitsComposition composition);

        Task<UnitsReference> GetReferenceAsync(int referenceId);
        Task AddReferenceAsync(UnitsReference reference);
        Task DeleteReferenceAsync(UnitsReference reference);
        Task UpdateReferenceAsync(UnitsReference reference);

        Task<UnitsType> GetUnitTypeAsync(int unitId);
        Task AddUnitTypeAsync(UnitsType unitType);
        Task DeleteUnitTypeAsync(UnitsType type);
        Task UpdateUnitTypeAsync(UnitsType unitType);
    }
}
