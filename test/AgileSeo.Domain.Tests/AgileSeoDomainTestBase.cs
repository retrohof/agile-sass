using Volo.Abp.Modularity;

namespace AgileSeo;

/* Inherit from this class for your domain layer tests. */
public abstract class AgileSeoDomainTestBase<TStartupModule> : AgileSeoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
