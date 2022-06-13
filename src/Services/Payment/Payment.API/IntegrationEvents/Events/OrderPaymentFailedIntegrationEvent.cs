namespace Microsoft.tonisgarden.Services.Payment.API.IntegrationEvents.Events;

public record OrderPaymentFailedIntegrationEvent(Guid OrderId) : IntegrationEvent;
