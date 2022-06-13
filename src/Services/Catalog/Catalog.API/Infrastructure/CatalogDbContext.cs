namespace Microsoft.tonisgarden.Services.Catalog.API.Infrastructure;

public class CatalogDbContext : DbContext
{
    public DbSet<CatalogSize> CatalogSizes => Set<CatalogSize>();
    public DbSet<CatalogItem> CatalogItems => Set<CatalogItem>();
    public DbSet<CatalogType> CatalogTypes => Set<CatalogType>();

    public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new CatalogSizeEntityTypeConfiguration());
        builder.ApplyConfiguration(new CatalogItemEntityTypeConfiguration());
        builder.ApplyConfiguration(new CatalogTypeEntityTypeConfiguration());
    }     
}
