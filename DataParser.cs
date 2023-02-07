using TeamYankeeBLL.DTO;
using TeamYankeeBLL.Exceptions;
using TeamYankeeBLL.SQL;
using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL
{
    public class DataParser : IDataParser
    {
        private readonly IRosterRepository _rosterRepo;
        private readonly IFormationsRepository _formationRepo;

        public DataParser(IRosterRepository rosterRepository, IFormationsRepository formationsRepository)
        {
            _rosterRepo = rosterRepository;
            _formationRepo = formationsRepository;
        }

        public async Task<List<NationDescription>> CollectNationsAsync()
        {
            List<NationDescription> nations = new();

            foreach (var nation in await _rosterRepo.GetAllNationsAsync())
            {
                nations.Add(new(nation));
            }

            return nations;
        }
        public async Task InsertNationAsync(NationDescription nation)
        {
            await _rosterRepo.AddNation(new() { Name = nation.Nationality });
        }
        public async Task DeleteNationAsync(int NationId)
        {
            var allNations = await _rosterRepo.GetAllNationsAsync();
            var nationToDelete = allNations.Where(n => n.Id == NationId).FirstOrDefault();
            if (nationToDelete == null)
                throw new NoDataException();
            await _rosterRepo.DeleteNation(nationToDelete);
        }
        public async Task UpdateNations(NationDescription updatedNation)
        {
            await _rosterRepo.UpdateNation(new() { Name = updatedNation.Nationality });
        }

        public async IAsyncEnumerable<RosterBrief> CollectRosterBriefAsync()
        {
            foreach (var description in await _rosterRepo.GetRostersDescryptionsAsync())
            {
                yield return new(description);
            }
        }
    }
}
