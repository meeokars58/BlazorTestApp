using BlazorTestApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace BlazorTestApp.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(BlazorTestAppEntityFrameworkCoreModule),
        typeof(BlazorTestAppApplicationContractsModule)
    )]
    public class BlazorTestAppDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }

}

