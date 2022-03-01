using System;
using System.Collections.Generic;
using System.Text;
using BlazorTestApp.Localization;
using Volo.Abp.Application.Services;

namespace BlazorTestApp
{
    /* Inherit your application services from this class.
     */
    public abstract class BlazorTestAppAppService : ApplicationService
    {
        protected BlazorTestAppAppService()
        {
            LocalizationResource = typeof(BlazorTestAppResource);
        }
    }

}

