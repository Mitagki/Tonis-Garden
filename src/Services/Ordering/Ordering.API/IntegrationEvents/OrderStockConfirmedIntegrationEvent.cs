namespace Microsoft.tonisgarden.Services.Ordering.API.IntegrationEvents;

public record OrderStockConfirmedIntegrationEvent(
    Guid OrderId)
    : IntegrationEvent;