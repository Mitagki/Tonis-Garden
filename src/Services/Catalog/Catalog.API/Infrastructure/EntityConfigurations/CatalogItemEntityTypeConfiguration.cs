namespace Microsoft.tonisgarden.Services.Catalog.API.Infrastructure.EntityConfigurations;

public class CatalogItemEntityTypeConfiguration : IEntityTypeConfiguration<CatalogItem>
{
    public void Configure(EntityTypeBuilder<CatalogItem> builder)
    {
        builder.ToTable("CatalogItem");

        builder.Property(item => item.Id)
            .UseHiLo("catalog_hilo")
            .IsRequired();

        builder.Property(item => item.Name)
            .IsRequired(true)
            .HasMaxLength(50);

        builder.Property(item => item.Price)
            .HasPrecision(4, 2)
            .IsRequired(true);

        builder.Property(item => item.PictureFileName)
            .IsRequired(true);

        builder.HasOne(item => item.CatalogSize)
            .WithMany()
            .HasForeignKey(item => item.CatalogSizeId);

        builder.HasOne(item => item.CatalogType)
            .WithMany()
            .HasForeignKey(item => item.CatalogTypeId);

        builder.HasData(
            new CatalogItem(18, "Peperomia Watermelon", 49, "21.png", 1, 1, 100),
            new CatalogItem(19, "Ficus Altissima", 99, "22.png", 1, 1, 100),
            new CatalogItem(20, "Ponytail Palm", 29, "23.png", 1, 1, 100),
            new CatalogItem(21, "Hoya Macrophylla", 49, "24.png", 1, 1, 100),
            new CatalogItem(22, "Peace Lily", 99, "25.png", 1, 1, 100),
            new CatalogItem(23, "Bamboo Palm", 99, "26.png", 1, 1, 100),
            new CatalogItem(24, "Money Tree", 99, "27.png", 1, 1, 100),
            new CatalogItem(25, "Red Prayer Plant", 39, "28.png", 1, 3, 100),
            new CatalogItem(26, "Dracaena Rikki Cane", 99, "29.png", 1, 3, 100),
            new CatalogItem(27, "Silver Pothos", 49, "30.png", 1, 2, 100),
            new CatalogItem(28, "Calathea Collection", 79, "31.png", 1, 2, 100),
            new CatalogItem(29, "Purple African Violet", 49, "32.png", 2, 1, 100),
            new CatalogItem(30, "Dieffenbachia", 99, "33.png", 2, 1, 100));
    }
}
