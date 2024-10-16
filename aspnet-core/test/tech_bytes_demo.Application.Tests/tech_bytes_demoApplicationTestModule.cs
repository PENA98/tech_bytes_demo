using Volo.Abp.Modularity;

namespace tech_bytes_demo;

[DependsOn(
    typeof(tech_bytes_demoApplicationModule),
    typeof(tech_bytes_demoDomainTestModule)
)]
public class tech_bytes_demoApplicationTestModule : AbpModule
{

}
