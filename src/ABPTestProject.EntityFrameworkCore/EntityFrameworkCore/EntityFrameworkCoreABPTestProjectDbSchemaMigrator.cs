using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ABPTestProject.Data;
using Volo.Abp.DependencyInjection;

namespace ABPTestProject.EntityFrameworkCore;

public class EntityFrameworkCoreABPTestProjectDbSchemaMigrator
    : IABPTestProjectDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreABPTestProjectDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ABPTestProjectDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ABPTestProjectDbContext>()
            .Database
            .MigrateAsync();
    }
}
