using CoffeLib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CoffeLib.Extensions;

namespace ProductApi;

public class SqlDbContext : DbContext, IDbContext
{
    public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
    {
        Products = Set<Coffee>();
    }

    public DbSet<Coffee> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CoffeEntityTypeConfig());
        SeedProductData(modelBuilder.Entity<Coffee>());
    }

    private void SeedProductData(EntityTypeBuilder<Coffee> entityTypeBuilder)
    {
        var reqs = new List<CoffeCreateReq>()
        {
            new()
            {
                Code = "CFF001",
                Name = "Moca",
                Category= "Hot",
                Price=3
            },
            new()
            {
                Code = "CFF002",
                Name = "Ice Latte",
                Category= "Ice",
                Price=4
            },
            new()
            {
                Code = "CFF003",
                Name = "Hot Latte",
                Category= "Hot",
                Price=5
            }
        };
        entityTypeBuilder.HasData(reqs.Select(x => x.ToEntity()));
    }
}
