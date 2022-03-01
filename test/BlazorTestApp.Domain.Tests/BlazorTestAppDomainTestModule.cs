using BlazorTestApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BlazorTestApp
{
    [DependsOn(
        typeof(BlazorTestAppEntityFrameworkCoreTestModule)
    )]
    public class BlazorTestAppDomainTestModule : AbpModule
    {

    }

}

