using Microsoft.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.TenantManagement;
using Volo.Abp.Threading;

namespace AgileSeo.EntityFrameworkCore;

public static class AgileSeoEfCoreEntityExtensionMappings
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        AgileSeoGlobalFeatureConfigurator.Configure();
        AgileSeoModuleExtensionConfigurator.Configure();

        ObjectExtensionManager.Instance
            .MapEfCoreProperty<Tenant, string>(Constant.Host);
    }
}
