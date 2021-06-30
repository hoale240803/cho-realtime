using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ChoRealtime.Controllers
{
    public abstract class ChoRealtimeControllerBase: AbpController
    {
        protected ChoRealtimeControllerBase()
        {
            LocalizationSourceName = ChoRealtimeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
