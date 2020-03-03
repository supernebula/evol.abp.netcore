using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evol.Abp.Web.Site.Controllers
{
    public abstract class AdvertControllerBase : AbpController
    {
        protected AdvertControllerBase()
        {
            LocalizationSourceName = AdvertConsts.LocalizationSourceName;
        }

        //protected void CheckErrors(IdentityResult identityResult)
        //{
        //    identityResult.CheckErrors(LocalizationManager);
        //}
    }
}
