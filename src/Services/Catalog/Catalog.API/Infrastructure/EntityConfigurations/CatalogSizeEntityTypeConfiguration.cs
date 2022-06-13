namespace Microsoft.tonisgarden.Services.Catalog.API.Infrastructure.EntityConfigurations;

public class CatalogSizeEntityTypeConfiguration : IEntityTypeConfiguration<CatalogSize>
{
    public void Configure(EntityTypeBuilder<CatalogSize> builder)
    {
        builder.ToTable("CatalogSize");

        builder.HasKey(size => size.Id);

        builder.Property(size => size.Id)
            .UseHiLo("catalog_size_hilo")
            .IsRequired();

        builder.Property(size => size.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasData(
            new CatalogSize(1, "Small"),
            new CatalogSize(2, "Medium"),
            new CatalogSize(3, "Large"));
    }
}
