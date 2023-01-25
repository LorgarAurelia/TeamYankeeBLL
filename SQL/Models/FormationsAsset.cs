using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class FormationsAsset
{
    public int Id { get; set; }

    public int FormationId { get; set; }

    public int UnitId { get; set; }

    public virtual UsersFormation Formation { get; set; } = null!;

    public virtual UsersUnit Unit { get; set; } = null!;
}
