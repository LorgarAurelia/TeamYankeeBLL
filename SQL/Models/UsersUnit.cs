using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class UsersUnit
{
    public int Id { get; set; }

    public int CompositionId { get; set; }

    public int ReferenceId { get; set; }

    public string Name { get; set; } = null!;

    public byte Cost { get; set; }

    public virtual UnitsComposition Composition { get; set; } = null!;

    public virtual ICollection<FormationsAsset> FormationsAssets { get; } = new List<FormationsAsset>();

    public virtual UnitsReference Reference { get; set; } = null!;

    public virtual ICollection<RostersContent> RostersContents { get; } = new List<RostersContent>();

    public virtual ICollection<RostersSupportUnit> RostersSupportUnits { get; } = new List<RostersSupportUnit>();

    public virtual ICollection<UsersUnitsOption> UsersUnitsOptions { get; } = new List<UsersUnitsOption>();
}
