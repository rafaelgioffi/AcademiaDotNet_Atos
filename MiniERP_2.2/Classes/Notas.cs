using System;
using System.Collections.Generic;

namespace MiniERP_2_2.Classes;

public partial class Notas
{
    public string NotId { get; set; } = null!;

    public string? NotInfo { get; set; }

    public DateTime? NotDataHora { get; set; }

    public string? NotTipo { get; set; }

    public int? CliId { get; set; }

    public int? ProdId { get; set; }

    public virtual Clientes? Cli { get; set; }

    public virtual Produtos? Prod { get; set; }
}
