using tech_bytes_demo.Samples;
using Xunit;

namespace tech_bytes_demo.EntityFrameworkCore.Applications;

[Collection(tech_bytes_demoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<tech_bytes_demoEntityFrameworkCoreTestModule>
{

}
