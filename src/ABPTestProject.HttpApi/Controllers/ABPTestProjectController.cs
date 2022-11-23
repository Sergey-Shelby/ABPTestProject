using ABPTestProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABPTestProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ABPTestProjectController : AbpControllerBase
{
    protected ABPTestProjectController()
    {
        LocalizationResource = typeof(ABPTestProjectResource);
    }
}
