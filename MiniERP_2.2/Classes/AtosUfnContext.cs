using Microsoft.EntityFrameworkCore;

namespace MiniERP_2_2.Classes;

public partial class AtosUfnContext : DbContext
{
    public AtosUfnContext()
    {
    }

    public AtosUfnContext(DbContextOptions<AtosUfnContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Clientes> Clientes { get; set; }

    public virtual DbSet<Fornecedores> Fornecedores { get; set; }

    public virtual DbSet<Notas> Notas { get; set; }

    public virtual DbSet<Produtos> Produtos { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=AtosUfn;User ID=rafael;Password=abc123;Language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;")
        .UseLazyLoadingProxies();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Clientes>(entity =>
        {
            entity.HasKey(e => e.CliId).HasName("PK__Clientes__FA1E289B38CCE98C");

            entity.Property(e => e.CliNome)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.CliTel)
                .HasMaxLength(14)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Fornecedores>(entity =>
        {
            entity.HasKey(e => e.FornId).HasName("PK__Forneced__FBC18D8462D550AD");

            entity.Property(e => e.FornCnpj)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.FornNome)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Notas>(entity =>
        {
            entity.HasKey(e => e.NotId).HasName("PK__Notas__4FB2008A50EA3751");

            entity.Property(e => e.NotId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.NotDataHora).HasColumnType("datetime");
            entity.Property(e => e.NotInfo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.NotTipo)
                .HasMaxLength(6)
                .IsUnicode(false);

            //entity.HasOne(d => d.Cli).WithMany(p => p.Nota)
                //.HasForeignKey(d => d.CliId)
                //.HasConstraintName("FK__Notas__CliId__73BA3083");

            //entity.HasOne(d => d.Prod).WithMany(p => p.Nota)
            //    .HasForeignKey(d => d.ProdId)
            //    .HasConstraintName("FK__Notas__ProdId__74AE54BC");
        });

        modelBuilder.Entity<Produtos>(entity =>
        {
            entity.HasKey(e => e.ProdId).HasName("PK__Produtos__042785E5F939D70D");

            entity.Property(e => e.ProdDesc).HasColumnType("text");
            entity.Property(e => e.ProdNome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProdValUnit).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Forn).WithMany(p => p.InverseForn)
                .HasForeignKey(d => d.FornId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Produtos__ProdQu__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
