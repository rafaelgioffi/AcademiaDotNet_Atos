using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AtosEntityDatabaseFirst;

public partial class AtosEntity2Context : DbContext
{
    public AtosEntity2Context()
    {
    }

    public AtosEntity2Context(DbContextOptions<AtosEntity2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Email> Emails { get; set; }

    public virtual DbSet<Pessoa> Pessoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=AtosEntity2;User ID=AtosEntity2;Password=AtosEntity2;Language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;")
        .UseLazyLoadingProxies();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Email>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Emails__3213E83FC3349E30");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FkPessoa).HasColumnName("fk_pessoa");

            entity.HasOne(d => d.FkPessoaNavigation).WithMany(p => p.Emails)
                .HasForeignKey(d => d.FkPessoa)
                .HasConstraintName("FK__Emails__fk_pesso__267ABA7A");
        });

        modelBuilder.Entity<Pessoa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pessoas__3213E83F23C47301");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
