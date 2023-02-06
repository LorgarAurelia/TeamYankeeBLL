using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL.DTO
{
    public class RosterSummary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentPoints { get; set; }
        public int PointsLimit { get; set; }
        public int ReinforcementsLimit { get; set; }
        public int CurrentReinforcements { get; set; }
        public int? NationId { get; set; }
        public List<FormationDesciption> FormationDesciptions { get; set; } = new();
        public List<UnitDesciption> Reinforcements { get; set; } = new();
        public List<UnitDesciption> SupportUnits { get; set; } = new();

        public RosterSummary(RosterDescription rosterDescription, List<FormationsReference> formations, List<UnitsReference> reinforcements, List<UnitsReference> supportUnits)
        {
            Id = rosterDescription.Id;
            Name = rosterDescription.Name;
            CurrentPoints = rosterDescription.CurrentPoints;
            PointsLimit = rosterDescription.PointsLimit;
            ReinforcementsLimit = rosterDescription.ReinforcementsLimit;
            CurrentReinforcements = rosterDescription.CurrentReinforcements;
            NationId = rosterDescription.NationId;

            foreach (var formation in formations)
                FormationDesciptions.Add(new(formation.Id, formation.Name));

            foreach (var unit in Reinforcements)
                Reinforcements.Add(new(unit.Id, unit.Name));

            foreach (var item in supportUnits)
                SupportUnits.Add(new(item.Id, item.Namne));
        }
    }
}
