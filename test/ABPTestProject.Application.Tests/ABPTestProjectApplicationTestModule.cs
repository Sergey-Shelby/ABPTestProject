using Volo.Abp.Modularity;

namespace ABPTestProject;

[DependsOn(
    typeof(ABPTestProjectApplicationModule),
    typeof(ABPTestProjectDomainTestModule)
    )]
public class ABPTestProjectApplicationTestModule : AbpModule
{

}
