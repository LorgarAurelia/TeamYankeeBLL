using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class UnitReferencesToSpecialRule
{
    public int Id { get; set; }

    public int SpecialRuleId { get; set; }

    public int UnitReferenceId { get; set; }

    public virtual SpecialRule SpecialRule { get; set; } = null!;

    public virtual UnitsReference UnitReference { get; set; } = null!;
}
