namespace Microsoft.tonisgarden.BlazorClient;

public class ApiAuthorizationMessageHandler : AuthorizationMessageHandler
{
    public ApiAuthorizationMessageHandler(
        IAccessTokenProvider provider,
        NavigationManager navigation,
        Settings settings)
        : base(provider, navigation)
    {
        ConfigureHandler(
            authorizedUrls: new[] { settings.ApiGatewayUrlExternal });
    }
}
