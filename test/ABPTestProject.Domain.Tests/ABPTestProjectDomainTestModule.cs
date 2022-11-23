using ABPTestProject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ABPTestProject;

[DependsOn(
    typeof(ABPTestProjectEntityFrameworkCoreTestModule)
    )]
public class ABPTestProjectDomainTestModule : AbpModule
{

}
