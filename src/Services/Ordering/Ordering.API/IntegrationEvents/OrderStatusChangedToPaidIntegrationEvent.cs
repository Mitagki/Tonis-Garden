namespace Microsoft.tonisgarden.Services.Ordering.API.IntegrationEvents;

public record OrderStatusChangedToPaidIntegrationEvent(
    Guid OrderId,
    string OrderStatus,
    string Description,
    IEnumerable<OrderStockItem> OrderStockItems,
    string BuyerId)
    : IntegrationEvent;
