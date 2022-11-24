namespace MiniERP_2_2.Classes;

public partial class Produto
{
    public int ProdId { get; set; }

    public int FornId { get; set; }

    public string ProdNome { get; set; } = null!;

    public string? ProdDesc { get; set; }

    public decimal ProdValUnit { get; set; }

    public int ProdQuant { get; set; }

    public virtual Produto Forn { get; set; } = null!;

    public virtual ICollection<Produto> InverseForn { get; } = new List<Produto>();

    public virtual ICollection<Nota> Nota { get; } = new List<Nota>();
}
