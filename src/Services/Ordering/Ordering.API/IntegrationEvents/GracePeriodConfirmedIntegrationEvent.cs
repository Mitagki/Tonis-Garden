namespace Microsoft.tonisgarden.Services.Ordering.API.IntegrationEvents;

public record GracePeriodConfirmedIntegrationEvent(int OrderId) : IntegrationEvent;
