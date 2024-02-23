using AgileSeo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AgileSeo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AgileSeoController : AbpControllerBase
{
    protected AgileSeoController()
    {
        LocalizationResource = typeof(AgileSeoResource);
    }
}
