using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SGA.Controllers
{
    public abstract class SGAControllerBase: AbpController
    {
        protected SGAControllerBase()
        {
            LocalizationSourceName = SGAConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
