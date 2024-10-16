using System;
using System.Collections.Generic;
using System.Text;
using tech_bytes_demo.Localization;
using Volo.Abp.Application.Services;

namespace tech_bytes_demo;

/* Inherit your application services from this class.
 */
public abstract class tech_bytes_demoAppService : ApplicationService
{
    protected tech_bytes_demoAppService()
    {
        LocalizationResource = typeof(tech_bytes_demoResource);
    }
}
