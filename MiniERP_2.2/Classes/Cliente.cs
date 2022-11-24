namespace MiniERP_2_2.Classes;

public partial class Cliente
{
    public int CliId { get; set; }

    public string CliNome { get; set; } = null!;

    public string? CliTel { get; set; }

    public virtual ICollection<Nota> Nota { get; } = new List<Nota>();
}
