using AgileSeo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AgileSeo.Permissions;

public class AgileSeoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AgileSeoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AgileSeoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AgileSeoResource>(name);
    }
}
