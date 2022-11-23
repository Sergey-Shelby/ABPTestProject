using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABPTestProject.Data;

/* This is used if database provider does't define
 * IABPTestProjectDbSchemaMigrator implementation.
 */
public class NullABPTestProjectDbSchemaMigrator : IABPTestProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
