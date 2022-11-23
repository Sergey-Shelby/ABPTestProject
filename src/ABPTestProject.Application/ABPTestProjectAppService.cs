using ABPTestProject.Localization;
using Volo.Abp.Application.Services;

namespace ABPTestProject;

/* Inherit your application services from this class.
 */
public abstract class ABPTestProjectAppService : ApplicationService
{
    protected ABPTestProjectAppService()
    {
        LocalizationResource = typeof(ABPTestProjectResource);
    }
}
