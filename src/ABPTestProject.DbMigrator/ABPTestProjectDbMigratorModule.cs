using ABPTestProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ABPTestProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ABPTestProjectEntityFrameworkCoreModule),
    typeof(ABPTestProjectApplicationContractsModule)
)]
public class ABPTestProjectDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options =>
        {
            options.IsJobExecutionEnabled = false;
        });
    }
}
