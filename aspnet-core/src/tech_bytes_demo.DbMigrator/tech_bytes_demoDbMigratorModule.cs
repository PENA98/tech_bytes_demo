using tech_bytes_demo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace tech_bytes_demo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(tech_bytes_demoEntityFrameworkCoreModule),
    typeof(tech_bytes_demoApplicationContractsModule)
    )]
public class tech_bytes_demoDbMigratorModule : AbpModule
{
}
