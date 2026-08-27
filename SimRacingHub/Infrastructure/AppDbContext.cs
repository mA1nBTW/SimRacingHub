using Microsoft.EntityFrameworkCore;
using SimRacingHub.Domain;
using System.Text.Json;

namespace SimRacingHub.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Setup> Setups { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Setup>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Parameters)
                .HasColumnType("jsonb")
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                    v => JsonSerializer.Deserialize<SetupParametersBase>(v, (JsonSerializerOptions?)null)!
                );
        });
    }
}
