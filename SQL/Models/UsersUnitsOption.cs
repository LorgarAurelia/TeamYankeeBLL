using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class UsersUnitsOption
{
    public int Id { get; set; }

    public int UnitId { get; set; }

    public int ReferenceId { get; set; }

    public byte Count { get; set; }

    public byte Cost { get; set; }

    public virtual UnitsOptionsReference Reference { get; set; } = null!;

    public virtual UsersUnit Unit { get; set; } = null!;
}
