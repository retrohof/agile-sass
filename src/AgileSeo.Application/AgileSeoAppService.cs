using System;
using System.Collections.Generic;
using System.Text;
using AgileSeo.Localization;
using Volo.Abp.Application.Services;

namespace AgileSeo;

/* Inherit your application services from this class.
 */
public abstract class AgileSeoAppService : ApplicationService
{
    protected AgileSeoAppService()
    {
        LocalizationResource = typeof(AgileSeoResource);
    }
}
