using BlazorTestApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BlazorTestApp.Permissions
{
    public class BlazorTestAppPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(BlazorTestAppPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(BlazorTestAppPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BlazorTestAppResource>(name);
        }
    }

}

