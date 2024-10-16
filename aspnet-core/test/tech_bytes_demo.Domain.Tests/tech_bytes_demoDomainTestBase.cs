using Volo.Abp.Modularity;

namespace tech_bytes_demo;

/* Inherit from this class for your domain layer tests. */
public abstract class tech_bytes_demoDomainTestBase<TStartupModule> : tech_bytes_demoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
