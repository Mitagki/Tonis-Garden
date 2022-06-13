﻿global using Dapr;
global using Dapr.Client;
global using Dapr.Extensions.Configuration;
global using HealthChecks.UI.Client;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.tonisgarden.BuildingBlocks.EventBus;
global using Microsoft.tonisgarden.BuildingBlocks.EventBus.Abstractions;
global using Microsoft.tonisgarden.BuildingBlocks.EventBus.Events;
global using Microsoft.tonisgarden.Services.Catalog.API;
global using Microsoft.tonisgarden.Services.Catalog.API.Infrastructure;
global using Microsoft.tonisgarden.Services.Catalog.API.Infrastructure.EntityConfigurations;
global using Microsoft.tonisgarden.Services.Catalog.API.IntegrationEvents.EventHandling;
global using Microsoft.tonisgarden.Services.Catalog.API.IntegrationEvents.Events;
global using Microsoft.tonisgarden.Services.Catalog.API.Model;
global using Microsoft.tonisgarden.Services.Catalog.API.ViewModel;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Diagnostics.HealthChecks;
global using Microsoft.Extensions.FileProviders;
global using Microsoft.Extensions.Hosting;
global using Microsoft.OpenApi.Models;
global using Polly;
global using System.Net;
