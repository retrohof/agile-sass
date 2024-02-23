﻿using AgileSeo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AgileSeo.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AgileSeoPageModel : AbpPageModel
{
    protected AgileSeoPageModel()
    {
        LocalizationResourceType = typeof(AgileSeoResource);
    }
}
