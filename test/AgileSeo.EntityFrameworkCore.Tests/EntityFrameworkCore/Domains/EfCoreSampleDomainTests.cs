using AgileSeo.Samples;
using Xunit;

namespace AgileSeo.EntityFrameworkCore.Domains;

[Collection(AgileSeoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AgileSeoEntityFrameworkCoreTestModule>
{

}
