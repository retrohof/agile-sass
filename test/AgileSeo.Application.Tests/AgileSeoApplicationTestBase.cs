using Volo.Abp.Modularity;

namespace AgileSeo;

public abstract class AgileSeoApplicationTestBase<TStartupModule> : AgileSeoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
