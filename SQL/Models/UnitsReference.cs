using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class UnitsReference
{
    public int Id { get; set; }

    public string Namne { get; set; } = null!;

    public bool IsSupport { get; set; }

    public bool IsBlackBox { get; set; }

    public byte? SupportsLimits { get; set; }

    public bool? IsHasSupportAlternative { get; set; }

    public int? AlternativeId { get; set; }

    public int? NationId { get; set; }

    public virtual ICollection<AircraftsSpecification> AircraftsSpecifications { get; } = new List<AircraftsSpecification>();

    public virtual ICollection<FormationsComposition> FormationsCompositionAlternativeUnits { get; } = new List<FormationsComposition>();

    public virtual ICollection<FormationsComposition> FormationsCompositionUnits { get; } = new List<FormationsComposition>();

    public virtual ICollection<HeavySpecification> HeavySpecifications { get; } = new List<HeavySpecification>();

    public virtual ICollection<InfantrySpecification> InfantrySpecifications { get; } = new List<InfantrySpecification>();

    public virtual Nation? Nation { get; set; }

    public virtual ICollection<UnitReferencesToSpecialRule> UnitReferencesToSpecialRules { get; } = new List<UnitReferencesToSpecialRule>();

    public virtual ICollection<UnitReferencesToWeapon> UnitReferencesToWeapons { get; } = new List<UnitReferencesToWeapon>();

    public virtual ICollection<UnitsComposition> UnitsCompositions { get; } = new List<UnitsComposition>();

    public virtual ICollection<UnitsOptionsReference> UnitsOptionsReferences { get; } = new List<UnitsOptionsReference>();

    public virtual ICollection<UnitsType> UnitsTypes { get; } = new List<UnitsType>();

    public virtual ICollection<UsersUnit> UsersUnits { get; } = new List<UsersUnit>();

    public virtual ICollection<VehicleSpecification> VehicleSpecifications { get; } = new List<VehicleSpecification>();

    public virtual ICollection<WeaponsToSpecialRule> WeaponsToSpecialRules { get; } = new List<WeaponsToSpecialRule>();
}
