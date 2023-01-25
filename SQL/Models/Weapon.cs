using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class Weapon
{
    public int Id { get; set; }

    public int? SpecialRuleId { get; set; }

    public string Name { get; set; } = null!;

    public string Range { get; set; } = null!;

    public byte Halted { get; set; }

    public byte Moving { get; set; }

    public byte Antitank { get; set; }

    public byte FirePower { get; set; }

    public virtual SpecialRule? SpecialRule { get; set; }

    public virtual ICollection<UnitReferencesToWeapon> UnitReferencesToWeapons { get; } = new List<UnitReferencesToWeapon>();

    public virtual ICollection<WeaponsToSpecialRule> WeaponsToSpecialRules { get; } = new List<WeaponsToSpecialRule>();
}
