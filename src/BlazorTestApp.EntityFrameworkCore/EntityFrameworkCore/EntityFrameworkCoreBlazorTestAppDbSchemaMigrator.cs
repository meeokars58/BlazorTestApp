using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BlazorTestApp.Data;
using Volo.Abp.DependencyInjection;

namespace BlazorTestApp.EntityFrameworkCore
{
    public class EntityFrameworkCoreBlazorTestAppDbSchemaMigrator
        : IBlazorTestAppDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreBlazorTestAppDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the BlazorTestAppDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<BlazorTestAppDbContext>()
                .Database
                .MigrateAsync();
        }
    }

}

