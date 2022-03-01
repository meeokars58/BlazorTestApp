using System.Threading.Tasks;

namespace BlazorTestApp.Data
{
    public interface IBlazorTestAppDbSchemaMigrator
    {
        Task MigrateAsync();
    }

}

