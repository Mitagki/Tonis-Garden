namespace Microsoft.tonisgarden.Services.Ordering.API.IntegrationEvents;

public record OrderStockRejectedIntegrationEvent(
    Guid OrderId,
    List<ConfirmedOrderStockItem> OrderStockItems)
    : IntegrationEvent;
