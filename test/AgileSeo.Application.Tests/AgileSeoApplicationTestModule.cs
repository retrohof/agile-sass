using Volo.Abp.Modularity;

namespace AgileSeo;

[DependsOn(
    typeof(AgileSeoApplicationModule),
    typeof(AgileSeoDomainTestModule)
)]
public class AgileSeoApplicationTestModule : AbpModule
{

}
