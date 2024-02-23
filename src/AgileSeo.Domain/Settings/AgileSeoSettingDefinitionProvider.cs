using Volo.Abp.Settings;

namespace AgileSeo.Settings;

public class AgileSeoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AgileSeoSettings.MySetting1));
    }
}
