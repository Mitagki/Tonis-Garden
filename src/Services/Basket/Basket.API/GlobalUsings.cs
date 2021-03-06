global using Dapr;
global using Dapr.Client;
global using HealthChecks.UI.Client;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.tonisgarden.BuildingBlocks.EventBus;
global using Microsoft.tonisgarden.BuildingBlocks.EventBus.Abstractions;
global using Microsoft.tonisgarden.BuildingBlocks.EventBus.Events;
global using Microsoft.tonisgarden.Services.Basket.API;
global using Microsoft.tonisgarden.Services.Basket.API.Infrastructure.Filters;
global using Microsoft.tonisgarden.Services.Basket.API.Infrastructure.Repositories;
global using Microsoft.tonisgarden.Services.Basket.API.IntegrationEvents.EventHandling;
global using Microsoft.tonisgarden.Services.Basket.API.IntegrationEvents.Events;
global using Microsoft.tonisgarden.Services.Basket.API.Model;
global using Microsoft.tonisgarden.Services.Basket.API.Services;
global using Microsoft.Extensions.Diagnostics.HealthChecks;
global using Microsoft.OpenApi.Models;
global using Swashbuckle.AspNetCore.SwaggerGen;
global using System.ComponentModel.DataAnnotations;
global using System.IdentityModel.Tokens.Jwt;
global using System.Net;
