namespace Microsoft.tonisgarden.Services.Ordering.API.IntegrationEvents;

public record OrderStatusChangedToShippedIntegrationEvent(
    Guid OrderId,
    string OrderStatus,
    string Description,
    string BuyerId)
    : IntegrationEvent;
