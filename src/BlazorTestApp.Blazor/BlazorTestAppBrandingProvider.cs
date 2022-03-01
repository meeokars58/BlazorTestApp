using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BlazorTestApp.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class BlazorTestAppBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "BlazorTestApp";
    }

}

