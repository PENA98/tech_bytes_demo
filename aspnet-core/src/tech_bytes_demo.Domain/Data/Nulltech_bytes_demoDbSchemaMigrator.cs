using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace tech_bytes_demo.Data;

/* This is used if database provider does't define
 * Itech_bytes_demoDbSchemaMigrator implementation.
 */
public class Nulltech_bytes_demoDbSchemaMigrator : Itech_bytes_demoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
