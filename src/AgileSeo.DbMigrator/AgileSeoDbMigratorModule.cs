using AgileSeo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AgileSeo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AgileSeoEntityFrameworkCoreModule),
    typeof(AgileSeoApplicationContractsModule)
    )]
public class AgileSeoDbMigratorModule : AbpModule
{
}
