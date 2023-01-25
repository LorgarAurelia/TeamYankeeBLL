using System;
using System.Collections.Generic;

namespace TeamYankeeBLL.SQL.Models;

public partial class UsersFormation
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ReferenceId { get; set; }

    public virtual ICollection<FormationsAsset> FormationsAssets { get; } = new List<FormationsAsset>();

    public virtual FormationsReference Reference { get; set; } = null!;

    public virtual ICollection<RostersContent> RostersContents { get; } = new List<RostersContent>();
}
