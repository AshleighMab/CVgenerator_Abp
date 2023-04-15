using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CV_Abp.Controllers
{
    public abstract class CV_AbpControllerBase: AbpController
    {
        protected CV_AbpControllerBase()
        {
            LocalizationSourceName = CV_AbpConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
