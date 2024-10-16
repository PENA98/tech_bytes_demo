using tech_bytes_demo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace tech_bytes_demo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class tech_bytes_demoController : AbpControllerBase
{
    protected tech_bytes_demoController()
    {
        LocalizationResource = typeof(tech_bytes_demoResource);
    }
}
