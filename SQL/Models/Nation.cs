using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class Nation
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<RosterDescription> Rosters { get; } = new List<RosterDescription>();

    public virtual ICollection<UnitsReference> UnitsReferences { get; } = new List<UnitsReference>();
}
