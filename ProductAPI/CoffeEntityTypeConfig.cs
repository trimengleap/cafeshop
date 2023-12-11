using CoffeLib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProductApi;

public class CoffeEntityTypeConfig : IEntityTypeConfiguration<Coffee>
{
    public void Configure(EntityTypeBuilder<Coffee> builder)
    {
        builder.ToTable("CoffeSM");
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Code).IsUnique(true);

        builder.Property(x => x.Id)
            .IsRequired(true)
            .HasColumnName(nameof(Coffee.Id))
            .HasColumnType("varchar")
            .HasMaxLength(36)
            .IsUnicode(false)
            ;
        builder.Property(x => x.Code)
            .IsRequired(true)
            .HasColumnName(nameof(Coffee.Code))
            .HasColumnType("nvarchar")
            .HasMaxLength(20)
            .IsUnicode(true)
            ;
        builder.Property(x => x.Name)
            .IsRequired(false)
            .HasColumnName(nameof(Coffee.Name))
            .HasColumnType("nvarchar")
            .HasMaxLength(50)
            .IsUnicode(true)
            ;
        builder.Property(x => x.Category)
            .IsRequired(true)
            .HasColumnName(nameof(Coffee.Category))
            .HasColumnType("tinyint")
            ;
        builder.Property(x => x.Price)
            .IsRequired(false)
            .HasColumnName(nameof(Coffee.Price))
            .HasColumnType("float")
            ;
        builder.Property(x => x.CreatedOn)
            .IsRequired(false)
            .HasColumnName(nameof(Coffee.CreatedOn))
            .HasColumnType("datetime")
            ;
    }
}
