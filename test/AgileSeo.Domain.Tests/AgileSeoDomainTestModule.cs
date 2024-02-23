using Volo.Abp.Modularity;

namespace AgileSeo;

[DependsOn(
    typeof(AgileSeoDomainModule),
    typeof(AgileSeoTestBaseModule)
)]
public class AgileSeoDomainTestModule : AbpModule
{

}
