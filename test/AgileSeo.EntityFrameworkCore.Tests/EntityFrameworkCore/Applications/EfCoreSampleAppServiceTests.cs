using AgileSeo.Samples;
using Xunit;

namespace AgileSeo.EntityFrameworkCore.Applications;

[Collection(AgileSeoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AgileSeoEntityFrameworkCoreTestModule>
{

}
