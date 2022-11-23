using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ABPTestProject;

[Dependency(ReplaceServices = true)]
public class ABPTestProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ABPTestProject";
}
