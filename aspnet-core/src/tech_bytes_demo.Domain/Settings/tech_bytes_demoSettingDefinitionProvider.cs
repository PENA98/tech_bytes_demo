using Volo.Abp.Settings;

namespace tech_bytes_demo.Settings;

public class tech_bytes_demoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(tech_bytes_demoSettings.MySetting1));
    }
}
