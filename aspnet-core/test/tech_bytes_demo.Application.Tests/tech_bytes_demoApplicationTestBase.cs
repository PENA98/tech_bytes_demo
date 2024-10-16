using Volo.Abp.Modularity;

namespace tech_bytes_demo;

public abstract class tech_bytes_demoApplicationTestBase<TStartupModule> : tech_bytes_demoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
