namespace Microsoft.tonisgarden.Services.Ordering.API.IntegrationEvents;

public record OrderPaymentSucceededIntegrationEvent(Guid OrderId) : IntegrationEvent;
