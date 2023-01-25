using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class UnitsOptionsReference
{
    public int Id { get; set; }

    public int UnitId { get; set; }

    public string Option { get; set; } = null!;

    public byte Price { get; set; }

    public byte OptionLimit { get; set; }

    public bool IsForAll { get; set; }

    public virtual UnitsReference Unit { get; set; } = null!;

    public virtual ICollection<UsersUnitsOption> UsersUnitsOptions { get; } = new List<UsersUnitsOption>();
}
