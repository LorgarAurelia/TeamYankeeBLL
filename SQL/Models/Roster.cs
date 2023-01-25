using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class RosterDescription
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public short CurrentPoints { get; set; }

    public short PointsLimit { get; set; }

    public byte ReinforcementsLimit { get; set; }

    public byte CurrentReinforcements { get; set; }

    public int? NationId { get; set; }

    public virtual Nation? Nation { get; set; }

    public virtual ICollection<RostersContent> RostersContents { get; } = new List<RostersContent>();
}
