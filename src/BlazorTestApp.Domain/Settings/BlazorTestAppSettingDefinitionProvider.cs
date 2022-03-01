using Volo.Abp.Settings;

namespace BlazorTestApp.Settings
{
    public class BlazorTestAppSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(BlazorTestAppSettings.MySetting1));
        }
    }

}

