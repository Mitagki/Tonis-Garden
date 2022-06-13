namespace Microsoft.tonisgarden.Services.Catalog.API.ViewModel;

public record PaginatedItemsViewModel(
    int PageIndex,
    int PageSize,
    long Count,
    IEnumerable<ItemViewModel> Items);
