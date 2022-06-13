var appName = "Identity API";
var builder = WebApplication.CreateBuilder();

builder.AddCustomConfiguration();
builder.AddCustomSerilog();
builder.AddCustomMvc();
builder.AddCustomDatabase();
builder.AddCustomIdentity();
builder.AddCustomIdentityServer();
builder.AddCustomAuthentication();
builder.AddCustomHealthChecks();
builder.AddCustomApplicationServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

var pathBase = builder.Configuration["PATH_BASE"];
if (!string.IsNullOrEmpty(pathBase))
{
    app.UsePathBase(pathBase);
}

app.UseStaticFiles();

app.UseCookiePolicy(new CookiePolicyOptions { MinimumSameSitePolicy = SameSiteMode.Lax });

app.UseRouting();

app.Use((context, next) =>
{
    if (context.Request.Headers.TryGetValue("x-arr-ssl", out var ssl) &&
        string.CompareOrdinal(ssl, "true") == 0)
    {
        context.Request.Scheme = "https";
    }

    return next();
});

app.UseIdentityServer();


app.UseAuthorization();

app.MapDefaultControllerRoute();

app.MapHealthChecks("/hc", new HealthCheckOptions()
{
    Predicate = _ => true,
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});
app.MapHealthChecks("/liveness", new HealthCheckOptions
{
    Predicate = r => r.Name.Contains("self")
});

try
{
    app.Logger.LogInformation("Seeding database ({ApplicationName})...", appName);
    using (var scope = app.Services.CreateScope())
    {
        await SeedData.EnsureSeedData(scope, app.Configuration, app.Logger);
    }

    app.Logger.LogInformation("Starting web host ({ApplicationName})...", appName);
    app.Run();

    return 0;
}
catch (Exception ex)
{
    app.Logger.LogCritical(ex, "Host terminated unexpectedly ({ApplicationName})...", appName);
    return 1;
}
finally
{
    Serilog.Log.CloseAndFlush();
}
