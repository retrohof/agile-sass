using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace AgileSeo.Web;

[Dependency(ReplaceServices = true)]
public class AgileSeoBrandingProvider : DefaultBrandingProvider
{
    private readonly ICurrentTenant _currentTenant;
    public override string AppName => _currentTenant.Name ?? "Agile Seo Sass";

    public AgileSeoBrandingProvider(ICurrentTenant currentTenant)
    {
        _currentTenant = currentTenant;
    }
}
