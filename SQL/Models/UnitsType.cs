using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class UnitsType
{
    public int Id { get; set; }

    public int? UnitId { get; set; }

    public bool? IsHeavyVehicle { get; set; }

    public bool? IsVehicle { get; set; }

    public bool IsInfantry { get; set; }

    public bool IsAircraft { get; set; }

    public virtual UnitsReference? Unit { get; set; }
}
