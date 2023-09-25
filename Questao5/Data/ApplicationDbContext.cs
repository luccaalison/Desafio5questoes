using Microsoft.EntityFrameworkCore;

namespace Questao5.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContaCorrente>()
            .HasKey(cc => cc.IdContaCorrente);
        
        modelBuilder.Entity<Movimento>()
           .HasKey(m => m.IdMovimento);

        base.OnModelCreating(modelBuilder);

    }

    public DbSet<ContaCorrente> ContasCorrentes { get; set; }
    public DbSet<Movimento> Movimentos { get; set; }
}
