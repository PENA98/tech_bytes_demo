using tech_bytes_demo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace tech_bytes_demo.Permissions;

public class tech_bytes_demoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(tech_bytes_demoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(tech_bytes_demoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<tech_bytes_demoResource>(name);
    }
}
