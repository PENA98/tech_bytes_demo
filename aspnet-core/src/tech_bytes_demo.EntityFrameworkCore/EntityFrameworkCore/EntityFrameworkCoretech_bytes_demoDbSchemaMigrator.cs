using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using tech_bytes_demo.Data;
using Volo.Abp.DependencyInjection;

namespace tech_bytes_demo.EntityFrameworkCore;

public class EntityFrameworkCoretech_bytes_demoDbSchemaMigrator
    : Itech_bytes_demoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoretech_bytes_demoDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the tech_bytes_demoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<tech_bytes_demoDbContext>()
            .Database
            .MigrateAsync();
    }
}
