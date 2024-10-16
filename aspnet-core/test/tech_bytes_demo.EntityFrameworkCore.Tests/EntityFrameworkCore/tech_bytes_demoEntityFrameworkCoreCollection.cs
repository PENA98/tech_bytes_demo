using Xunit;

namespace tech_bytes_demo.EntityFrameworkCore;

[CollectionDefinition(tech_bytes_demoTestConsts.CollectionDefinitionName)]
public class tech_bytes_demoEntityFrameworkCoreCollection : ICollectionFixture<tech_bytes_demoEntityFrameworkCoreFixture>
{

}
