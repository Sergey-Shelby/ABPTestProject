using System.Threading.Tasks;

namespace ABPTestProject.Data;

public interface IABPTestProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
