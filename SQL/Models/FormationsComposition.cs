using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class FormationsComposition
{
    public int Id { get; set; }

    public int FormationId { get; set; }

    public int UnitId { get; set; }

    public byte MinimalCount { get; set; }

    public byte MaximumCount { get; set; }

    public bool HasAlternative { get; set; }

    public int? AlternativeUnitId { get; set; }

    public virtual UnitsReference? AlternativeUnit { get; set; }

    public virtual FormationsReference Formation { get; set; } = null!;

    public virtual UnitsReference Unit { get; set; } = null!;
}
