using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class UnitsComposition
{
    public int Id { get; set; }

    public int UnitId { get; set; }

    public byte Price { get; set; }

    public virtual UnitsReference Unit { get; set; } = null!;

    public virtual ICollection<UsersUnit> UsersUnits { get; } = new List<UsersUnit>();
}
