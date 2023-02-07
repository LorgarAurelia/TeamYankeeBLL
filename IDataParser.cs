using TeamYankeeBLL.DTO;

namespace TeamYankeeBLL
{
    public interface IDataParser
    {
        Task AddNationAsync(NationDescription nation);
        Task<List<NationDescription>> CollectNationsAsync();
        Task DeleteNationAsync(int NationId);
    }
}