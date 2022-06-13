namespace Microsoft.tonisgarden.Services.Catalog.API.IntegrationEvents.Events;

public record OrderStockConfirmedIntegrationEvent(Guid OrderId) : IntegrationEvent;
