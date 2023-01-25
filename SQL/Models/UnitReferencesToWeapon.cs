using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class UnitReferencesToWeapon
{
    public int Id { get; set; }

    public int WeaponsId { get; set; }

    public int UnitReferenceId { get; set; }

    public virtual UnitsReference UnitReference { get; set; } = null!;

    public virtual Weapon Weapons { get; set; } = null!;
}
