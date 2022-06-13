namespace Microsoft.tonisgarden.Services.Ordering.API.IntegrationEvents;

public record OrderPaymentFailedIntegrationEvent(Guid OrderId) : IntegrationEvent;
