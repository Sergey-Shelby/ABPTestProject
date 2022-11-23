using Volo.Abp.Settings;

namespace ABPTestProject.Settings;

public class ABPTestProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ABPTestProjectSettings.MySetting1));
    }
}
