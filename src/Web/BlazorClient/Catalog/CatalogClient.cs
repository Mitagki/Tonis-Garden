namespace Microsoft.tonisgarden.BlazorClient.Catalog;

public class CatalogClient
{
    private const int PageSize = 12;

    private readonly HttpClient httpClient;

    public CatalogClient(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public Task<IEnumerable<CatalogSize>> GetSizesAsync() =>
        httpClient.GetFromJsonAsync<IEnumerable<CatalogSize>>(
            "c/api/v1/catalog/sizes")!;

    public Task<IEnumerable<CatalogType>> GetTypesAsync() =>
        httpClient.GetFromJsonAsync<IEnumerable<CatalogType>>(
            "c/api/v1/catalog/types")!;

    public Task<CatalogPage> GetItemsAsync(int sizeId, int typeId, int pageIndex) =>
        httpClient.GetFromJsonAsync<CatalogPage>(
            $"c/api/v1/catalog/items/by_page?sizeId={sizeId}&typeId={typeId}&pageIndex={pageIndex}&pageSize={PageSize}")!;
}
