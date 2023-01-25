using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class WeaponsToSpecialRule
{
    public int Id { get; set; }

    public int WeaponsId { get; set; }

    public int SpecialRuleId { get; set; }

    public virtual UnitsReference SpecialRule { get; set; } = null!;

    public virtual Weapon Weapons { get; set; } = null!;
}
