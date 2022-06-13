namespace Microsoft.tonisgarden.Services.Ordering.API.IntegrationEvents;

public record ConfirmedOrderStockItem(int ProductId, bool HasStock);
