using BlazorTestApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace BlazorTestApp.Blazor
{
    public abstract class BlazorTestAppComponentBase : AbpComponentBase
    {
        protected BlazorTestAppComponentBase()
        {
            LocalizationResource = typeof(BlazorTestAppResource);
        }
    }

}

