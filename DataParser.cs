using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamYankeeBLL.DTO;
using TeamYankeeBLL.Exceptions;
using TeamYankeeBLL.SQL;

namespace TeamYankeeBLL
{
    public class DataParser : IDataParser
    {
        private readonly IRosterRepository _rosterRepo;

        public DataParser(IRosterRepository rosterRepository)
        {
            _rosterRepo = rosterRepository;
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
        public async Task AddNationAsync(NationDescription nation)
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

    }
}
