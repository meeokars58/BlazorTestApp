using BlazorTestApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BlazorTestApp.Controllers
{
    public abstract class BlazorTestAppController : AbpControllerBase
    {
        protected BlazorTestAppController()
        {
            LocalizationResource = typeof(BlazorTestAppResource);
        }
    }

}

/* Inherit your controllers from this class.
 */
