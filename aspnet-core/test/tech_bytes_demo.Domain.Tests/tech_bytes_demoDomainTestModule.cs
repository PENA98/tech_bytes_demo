using Volo.Abp.Modularity;

namespace tech_bytes_demo;

[DependsOn(
    typeof(tech_bytes_demoDomainModule),
    typeof(tech_bytes_demoTestBaseModule)
)]
public class tech_bytes_demoDomainTestModule : AbpModule
{

}
