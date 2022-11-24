namespace MiniERP_2_2.Classes;

public partial class Clientes
{
    public int CliId { get; set; }

    public string CliNome { get; set; } = null!;

    public string? CliTel { get; set; }

    public virtual ICollection<Notas> Nota { get; } = new List<Notas>();
}
