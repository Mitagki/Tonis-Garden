namespace Microsoft.tonisgarden.Web.Shopping.HttpAggregator.Services;

public interface ICatalogService
{
    Task<IEnumerable<CatalogItem>?> GetCatalogItemsAsync(IEnumerable<int> ids);
}
