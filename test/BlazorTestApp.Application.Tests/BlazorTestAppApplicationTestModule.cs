using Volo.Abp.Modularity;

namespace BlazorTestApp
{
    [DependsOn(
        typeof(BlazorTestAppApplicationModule),
        typeof(BlazorTestAppDomainTestModule)
    )]
    public class BlazorTestAppApplicationTestModule : AbpModule
    {

    }

}

