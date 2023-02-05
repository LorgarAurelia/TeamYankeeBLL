using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL.SQL
{
    internal interface IOptionsRepository
    {
        Task<List<UsersUnitsOption>> GetUnitOptionsAsync(int unitId);
        Task AddUserUnitOption(UsersUnitsOption unitOption);
        Task DeleteUserUnitOption(UsersUnitsOption unit);
        Task UpdateUserUnitOption(UsersUnitsOption unitOption);

        Task<UnitsOptionsReference> GetOptionReferenceAsync(int refrenceId);
        Task AddOptionReferenceAsync(UnitsOptionsReference reference);
        Task DeleteOptionReferenceAsync(UnitsOptionsReference refrence);
        Task UpdateOptionReferenceAsync(UnitsOptionsReference reference);
    }
}