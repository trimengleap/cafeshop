using CoffeLib;
using Microsoft.EntityFrameworkCore;
using CoffeLib.Extensions;

namespace ProductApi;

public class MemoryDbContext : DbContext, IDbContext
{
    public MemoryDbContext(DbContextOptions<MemoryDbContext> options) : base(options)
    {
        Products = Set<Coffee>();
    }

    public DbSet<Coffee> Products { get; set; }
}
