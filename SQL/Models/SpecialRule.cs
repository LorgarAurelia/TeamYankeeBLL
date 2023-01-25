using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class SpecialRule
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<UnitReferencesToSpecialRule> UnitReferencesToSpecialRules { get; } = new List<UnitReferencesToSpecialRule>();

    public virtual ICollection<Weapon> Weapons { get; } = new List<Weapon>();
}
