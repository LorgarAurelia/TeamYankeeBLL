namespace TeamYankeeBLL.SQL.Models;

public partial class FormationsReference
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsHomemade { get; set; }

    public int? NationId { get; set; }

    public virtual ICollection<FormationsComposition> FormationsCompositions { get; } = new List<FormationsComposition>();

    public virtual ICollection<UsersFormation> UsersFormations { get; } = new List<UsersFormation>();
}
