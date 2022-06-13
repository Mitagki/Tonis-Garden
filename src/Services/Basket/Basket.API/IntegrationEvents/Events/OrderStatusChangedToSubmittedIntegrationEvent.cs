namespace Microsoft.tonisgarden.Services.Basket.API.IntegrationEvents.Events;

public record OrderStatusChangedToSubmittedIntegrationEvent(
    Guid OrderId,
    string OrderStatus,
    string BuyerId)
    : IntegrationEvent;
