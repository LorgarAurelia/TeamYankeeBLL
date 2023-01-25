using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class RostersSupportUnit
{
    public int Id { get; set; }

    public int RosterId { get; set; }

    public int SuppotUnitId { get; set; }

    public virtual UsersUnit SuppotUnit { get; set; } = null!;
}
