using Microsoft.EntityFrameworkCore;

namespace CoffeLib
{
    public interface IDbContext
    {
        DbSet<Coffee> Products { get; set; }

        int SaveChanges();
    }
}