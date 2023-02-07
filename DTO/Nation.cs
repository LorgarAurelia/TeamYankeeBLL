using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL.DTO
{
    public class NationDescription
    {
        public int? Id { get; set; }
        public string Nationality { get; set; }
        public NationDescription(Nation nation)
        {
            Id = nation.Id;
            Nationality = nation.Name;
        }
        public NationDescription()
        {

        }
    }
}
