namespace Microsoft.tonisgarden.Services.Payment.API.IntegrationEvents.EventHandling;

public class OrderStatusChangedToValidatedIntegrationEventHandler :
    IIntegrationEventHandler<OrderStatusChangedToValidatedIntegrationEvent>
{
    private readonly PaymentSettings _settings;
    private readonly IEventBus _eventBus;
    private readonly ILogger _logger;

    public OrderStatusChangedToValidatedIntegrationEventHandler(
        IOptions<PaymentSettings> settings,
        IEventBus eventBus,
        ILogger<OrderStatusChangedToValidatedIntegrationEventHandler> logger)
    {
        _settings = settings.Value;
        _eventBus = eventBus;
        _logger = logger;
    }

    public async Task Handle(OrderStatusChangedToValidatedIntegrationEvent @event)
    {
        IntegrationEvent orderPaymentIntegrationEvent;

        await Task.Delay(3000);

        if (_settings.PaymentSucceeded &&
            (!_settings.MaxOrderTotal.HasValue || @event.Total < _settings.MaxOrderTotal ))
        {
            orderPaymentIntegrationEvent = new OrderPaymentSucceededIntegrationEvent(@event.OrderId);
        }
        else
        {
            _logger.LogWarning(
                "Payment for ${Total} rejected for order {OrderId} because of service configuration",
                @event.Total,
                @event.OrderId);

            orderPaymentIntegrationEvent = new OrderPaymentFailedIntegrationEvent(@event.OrderId);
        }

        await _eventBus.PublishAsync(orderPaymentIntegrationEvent);
    }
}
