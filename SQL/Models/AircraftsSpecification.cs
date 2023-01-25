using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class AircraftsSpecification
{
    public int Id { get; set; }

    public int UnitId { get; set; }

    public byte Courage { get; set; }

    public byte Morale { get; set; }

    public byte Skill { get; set; }

    public byte IsHitOn { get; set; }

    public byte AircraftSave { get; set; }

    public virtual UnitsReference Unit { get; set; } = null!;
}
