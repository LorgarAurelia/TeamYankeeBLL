using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class RostersContent
{
    public int Id { get; set; }

    public int RosterId { get; set; }

    public int? BlackBoxUnitId { get; set; }

    public int FormationId { get; set; }

    public virtual UsersUnit? BlackBoxUnit { get; set; }

    public virtual UsersFormation Formation { get; set; } = null!;

    public virtual RosterDescription Roster { get; set; } = null!;
}
