using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AgileSeo.Data;
using Volo.Abp.DependencyInjection;

namespace AgileSeo.EntityFrameworkCore;

public class EntityFrameworkCoreAgileSeoDbSchemaMigrator
    : IAgileSeoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAgileSeoDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the AgileSeoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AgileSeoDbContext>()
            .Database
            .MigrateAsync();
    }
}
