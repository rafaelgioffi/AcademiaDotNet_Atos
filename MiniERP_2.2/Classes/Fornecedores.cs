using System;
using System.Collections.Generic;

namespace MiniERP_2_2.Classes;

public partial class Fornecedores
{
    public int FornId { get; set; }

    public string FornNome { get; set; } = null!;

    public string? FornCnpj { get; set; }
}
