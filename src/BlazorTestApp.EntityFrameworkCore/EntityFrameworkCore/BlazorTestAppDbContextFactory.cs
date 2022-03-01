using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BlazorTestApp.EntityFrameworkCore
{
    public class BlazorTestAppDbContextFactory : IDesignTimeDbContextFactory<BlazorTestAppDbContext>
    {
        public BlazorTestAppDbContext CreateDbContext(string[] args)
        {
            BlazorTestAppEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BlazorTestAppDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new BlazorTestAppDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../BlazorTestApp.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }

}

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
