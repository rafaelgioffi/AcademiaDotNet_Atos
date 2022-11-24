namespace MiniERP_2_2.Classes;

public partial class Produtos
{
    public int ProdId { get; set; }

    public int FornId { get; set; }

    public string ProdNome { get; set; } = null!;

    public string? ProdDesc { get; set; }

    public decimal ProdValUnit { get; set; }

    public int ProdQuant { get; set; }

    public virtual Produtos Forn { get; set; } = null!;

    public virtual ICollection<Produtos> InverseForn { get; } = new List<Produtos>();

    public virtual ICollection<Notas> Nota { get; } = new List<Notas>();
}
