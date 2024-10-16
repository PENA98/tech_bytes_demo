using tech_bytes_demo.Samples;
using Xunit;

namespace tech_bytes_demo.EntityFrameworkCore.Domains;

[Collection(tech_bytes_demoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<tech_bytes_demoEntityFrameworkCoreTestModule>
{

}
