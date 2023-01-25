using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class HeavySpecification
{
    public int Id { get; set; }

    public int? UnitId { get; set; }

    public byte Courage { get; set; }

    public byte Morale { get; set; }

    public byte Remount { get; set; }

    public byte Skill { get; set; }

    public byte Assault { get; set; }

    public byte Counterattack { get; set; }

    public byte IsHitOn { get; set; }

    public byte Front { get; set; }

    public byte Side { get; set; }

    public byte Top { get; set; }

    public string Tactical { get; set; } = null!;

    public string TerrainDash { get; set; } = null!;

    public string CrossCountryDash { get; set; } = null!;

    public string RoadDash { get; set; } = null!;

    public byte Cross { get; set; }

    public virtual UnitsReference? Unit { get; set; }
}
