using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BlazorTestApp.Data{
    public class NullBlazorTestAppDbSchemaMigrator : IBlazorTestAppDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}

/* This is used if database provider does't define
 * IBlazorTestAppDbSchemaMigrator implementation.
 */
