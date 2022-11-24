using System;
using System.Collections.Generic;

namespace MiniERP_2_2.Classes;

public partial class Nota
{
    public string NotId { get; set; } = null!;

    public string? NotInfo { get; set; }

    public DateTime? NotDataHora { get; set; }

    public string? NotTipo { get; set; }

    public int? CliId { get; set; }

    public int? ProdId { get; set; }

    public virtual Cliente? Cli { get; set; }

    public virtual Produto? Prod { get; set; }
}
