using Microsoft.EntityFrameworkCore;

namespace AdivinheONumero.db;

public partial class DbAdivinheONumeroContext : DbContext
{
    public DbAdivinheONumeroContext()
    {
    }

    public DbAdivinheONumeroContext(DbContextOptions<DbAdivinheONumeroContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Jogo> Jogo { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;port=3306;uid=root;pwd=root;database=db_adivinhe_o_numero", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.39-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Jogo>(entity =>
        {
            entity.HasKey(e => e.IdJogador).HasName("PRIMARY");

            entity.ToTable("jogo");

            entity.Property(e => e.IdJogador).HasColumnName("id_jogador");
            entity.Property(e => e.NmEmail)
                .HasMaxLength(40)
                .HasColumnName("nm_email");
            entity.Property(e => e.NmJogador)
                .HasMaxLength(30)
                .HasColumnName("nm_jogador");
            entity.Property(e => e.NmSenha)
                .HasMaxLength(20)
                .HasColumnName("nm_senha");
            entity.Property(e => e.NrDerrota)
                .HasDefaultValueSql("'0'")
                .HasColumnName("nr_derrota");
            entity.Property(e => e.NrPartida)
                .HasDefaultValueSql("'0'")
                .HasColumnName("nr_partida");
            entity.Property(e => e.NrTelefone)
                .HasMaxLength(11)
                .HasColumnName("nr_telefone");
            entity.Property(e => e.NrVitoria)
                .HasDefaultValueSql("'0'")
                .HasColumnName("nr_vitoria");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
