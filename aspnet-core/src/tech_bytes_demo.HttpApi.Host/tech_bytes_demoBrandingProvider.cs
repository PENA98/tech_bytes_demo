using Microsoft.Extensions.Localization;
using tech_bytes_demo.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace tech_bytes_demo;

[Dependency(ReplaceServices = true)]
public class tech_bytes_demoBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<tech_bytes_demoResource> _localizer;

    public tech_bytes_demoBrandingProvider(IStringLocalizer<tech_bytes_demoResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
